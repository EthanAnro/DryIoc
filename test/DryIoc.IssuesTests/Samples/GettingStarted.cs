﻿using NUnit.Framework;

namespace DryIoc.IssuesTests.Samples
{
    [TestFixture]
    public class GettingStarted : ITest
    {
        public int Run()
        {
            Register_some_client_and_service_types_Then_resolve_client_with_injected_service();
            Specify_reuse_type_for_resolved_injected_objects();
            If_you_forgot_to_register_service_type_Container_will_guide_you_with_exception_message();
            Unable_to_resolve_in_case_of_wrong_key();
            Unable_to_resolve_in_case_of_no_scope();
            return 5;
        }

        [Test]
        public void Register_some_client_and_service_types_Then_resolve_client_with_injected_service()
        {
            var container = new Container();
            container.Register<IClient, SomeClient>();
            container.Register<IService, SomeService>(Reuse.Singleton);
            // or alternatively:
            //container.Register(typeof(IService), typeof(SomeService), Reuse.Singleton);
            //container.RegisterAll<SomeService>(Reuse.Singleton);

            var client = container.Resolve<IClient>();
            // or alternatively:
            //var client = container.Resolve(typeof(IClient));

            Assert.That(client, Is.InstanceOf<SomeClient>());
            Assert.That(client.Service, Is.InstanceOf<SomeService>());
        }

        [Test]
        public void Specify_reuse_type_for_resolved_injected_objects()
        {
            var container = new Container();

            // Transient reuse means no reuse at all.
            // Every time client is resolved/injected a new object will be created.
            container.Register<IClient, SomeClient>(Reuse.Transient);
            // You can omit reuse parameter when registering Transient objects.
            // container.Register<IClient, SomeClient>();

            // Singleton means that service object will be created at first resolve/injection,
            // then the same instance will be returned for all subsequent resolves from this container.
            container.Register<IService, SomeService>(Reuse.Singleton);

            var client = container.Resolve<IClient>();
            var anotherClient = container.Resolve<IClient>();

            Assert.That(client, Is.Not.SameAs(anotherClient));
            Assert.That(client.Service, Is.SameAs(anotherClient.Service));
        }

        [Test]
        public void If_you_forgot_to_register_service_type_Container_will_guide_you_with_exception_message()
        {
            var container = new Container();
            container.Register<IClient, SomeClient>();
            // forgot to container.Register<IService, SomeService>(Reuse.Singleton);

            var ex = Assert.Throws<ContainerException>(() =>
                container.Resolve<IClient>());

            // Unable to resolve IService as parameter "service"
            //   in SomeClient: IClient #27
            //   from container
            // Where no service registrations found
            //   and no dynamic registrations found in 0 Rules.DynamicServiceProviders
            //   and nothing in 0 Rules.UnknownServiceResolvers

            StringAssert.Contains("Unable to resolve", ex.Message);
            StringAssert.Contains("parameter \"service\"", ex.Message);
            StringAssert.Contains("Where no service registrations found", ex.Message);
        }

        [Test]
        public void Unable_to_resolve_in_case_of_wrong_key()
        {
            var container = new Container();
            container.Register<X>();
            container.Register<Y>(serviceKey: "special");

            var ex = Assert.Throws<ContainerException>(() => 
                container.Resolve<X>());

            Assert.AreEqual(ex.Error, Error.UnableToResolveFromRegisteredServices);
        }

        [Test]
        public void Unable_to_resolve_in_case_of_no_scope()
        {
            var container = new Container();
            container.Register<X>();
            container.Register<Y>(Reuse.Scoped);

            var ex = Assert.Throws<ContainerException>(() => container.Resolve<X>());

            Assert.AreEqual(Error.NameOf(Error.NoCurrentScope), ex.ErrorName);
        }

        class X
        {
            public Y Y { get; private set; }
            public X(Y y)
            {
                Y = y;
            }
        }
        
        class Y {}
    }

    public interface IService { }

    public class SomeService : IService { }

    public interface IClient
    {
        IService Service { get; }
    }

    public class SomeClient : IClient
    {
        public IService Service { get; private set; }

        public SomeClient(IService service)
        {
            Service = service;
        }
    }
}
