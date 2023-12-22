﻿using System;
using System.Collections.Generic;
using System.Linq;
using DryIoc.UnitTests.CUT;
using NUnit.Framework;

namespace DryIoc.UnitTests
{
    [TestFixture]
    public class RequiredServiceTypeTests : ITest
    {
        public int Run()
        {
            Resolving_service_with_not_assignable_required_type_should_Throw();
            Resolving_Lazy_service_with_required_type_and_key_should_work();
            Resolve_array_of_required_type_should_work();
            Resolve_Enumerable_of_required_type_should_work();
            Resolve_Many_of_required_type_should_work();
            Resolve_Many_services_twice_with_different_required_types_should_work();
            Resolve_Meta_of_Func_of_required_type_should_work();
            Resolve_required_service_type_without_key();
            Can_specify_generic_for_Func_of_object_for_ResolveMany();
            Can_specify_to_Resolve_open_over_closed_generic();
            return 10;
        }

        [Test]
        public void Resolving_service_with_not_assignable_required_type_should_Throw()
        {
            var container = new Container();
            container.Register<Service>();

            var ex = Assert.Throws<ContainerException>(
                () => container.Resolve<string>(typeof(Service)));

            Assert.AreEqual(
                Error.NameOf(Error.UnableToResolveUnknownService),
                Error.NameOf(ex.Error));
        }

        [Test]
        public void Resolving_Lazy_service_with_required_type_and_key_should_work()
        {
            var container = new Container();
            container.Register<Service>(serviceKey: 1);

            var service = container.Resolve<IService>(1, requiredServiceType: typeof(Service));

            Assert.That(service, Is.Not.Null);
        }

        [Test]
        public void Resolve_array_of_required_type_should_work()
        {
            var container = new Container();
            container.Register<IService, Service>();

            var services = container.Resolve<object[]>(typeof(IService));

            Assert.That(services.Length, Is.EqualTo(1));
        }

        [Test]
        public void Resolve_Enumerable_of_required_type_should_work()
        {
            var container = new Container();
            container.Register<IService, Service>();

            var services = container.Resolve<IEnumerable<Func<object>>>(typeof(IService));

            Assert.That(services.Count(), Is.EqualTo(1));
            Assert.That(services.First().Invoke(), Is.InstanceOf<Service>());
        }

        [Test]
        public void Resolve_Many_of_required_type_should_work()
        {
            var container = new Container();
            container.Register<IService, Service>();

            var services = container.Resolve<LazyEnumerable<object>>(typeof(IService));

            Assert.That(services.Items.Count(), Is.EqualTo(1));
        }

        [Test]
        public void Resolve_Many_services_twice_with_different_required_types_should_work()
        {
            var container = new Container();
            using (var scope = container.OpenScope())
            {
                container.Register<IService, Service>(Reuse.InCurrentScope);

                var objects = scope.Resolve<LazyEnumerable<object>>(typeof(IService));
                var services = scope.Resolve<LazyEnumerable<IService>>(typeof(IService));

                CollectionAssert.AreEqual(objects.Items.Cast<IService>().ToArray(), services.Items.ToArray());             
            }
        }

        [Test]
        public void Resolve_Meta_of_Func_of_required_type_should_work()
        {
            var container = new Container();
            container.Register<IService, Service>(setup: Setup.With("a"));
            container.Register<IService, AnotherService>(setup: Setup.With("b"));

            var services = container.Resolve<Meta<Func<object>, string>[]>(typeof(IService));

            Assert.AreEqual(2, services.Length);
            Assert.That(services[0].Metadata, Is.EqualTo("a"));
            Assert.That(services[0].Value(), Is.InstanceOf<Service>());
            Assert.That(services[1].Metadata, Is.EqualTo("b"));
        }

        [Test]
        public void Resolve_required_service_type_without_key()
        {
            var container = new Container();
            container.Register<Service>();

            var service = container.Resolve<IService>(typeof(Service));

            Assert.That(service, Is.InstanceOf<Service>());
        }

        [Test]
        public void Can_specify_generic_for_Func_of_object_for_ResolveMany()
        {
            var container = new Container();
            container.Register(typeof(A<>));

            var services = container.ResolveMany<Func<object>>(typeof(A<int>));

            Assert.IsInstanceOf<A<int>>(services.First().Invoke());
        }

        public class A<T> { }

        [Test]
        public void Can_specify_to_Resolve_open_over_closed_generic()
        {
            var container = new Container();
            container.Register(typeof(IMa<string>), typeof(Sa));
            container.Register(typeof(IMa<>), typeof(Ta<>));

            var ma = container.Resolve<IMa<string>>(typeof(IMa<>));

            Assert.IsInstanceOf<Ta<string>>(ma);
        }

        public interface IMa<T> { }
        public class Sa : IMa<string> { }
        public class Ta<T> : IMa<T> { }
    }
}
