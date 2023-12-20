﻿using System;
using System.ComponentModel.Composition;
using DryIoc.MefAttributedModel.UnitTests.CUT;
using DryIocAttributes;
using NUnit.Framework;

namespace DryIoc.MefAttributedModel.UnitTests
{
    [TestFixture]
    public class ImportAttributeTests : ITest
    {
        public int Run()
        {
            Inject_service_as_parameter_of_required_service_type_specified_by_Import_ContractType();
            Inject_service_as_Func_of_Service_with_Import_contract_type();
            Inject_service_as_Lazy_of_Service_with_Import_contract_type();
            Inject_service_as_Lazy_Meta_of_Service_with_Import_contract_type();
            Inject_service_as_Func_Array_of_Service_with_Import_contract_type();
            Inject_service_as_Func_Array_of_Service_with_Import_contract_key_no_type_specified();
            Inject_property_with_default_Import_should_work();
            Resolve_property_for_already_resolved_instance();
            Resolving_unregistered_property_marked_by_Import_should_throw();
            Resolving_unregistered_property_without_attribute_model_should_not_throw_so_the_property_stays_null();
            Resolving_registered_property_with_not_assignable_type_should_Throw();
            Resolve_custom_generic_wrapper_marked_with_Import();
            Could_import_property_with_internal_setter();
            When_resolving_props_and_fields_manually_required_type_should_work();
            return 14;
        }

        [Test]
        public void Inject_service_as_parameter_of_required_service_type_specified_by_Import_ContractType()
        {
            var container = new Container().WithMefAttributedModel();
            container.RegisterExports(typeof(Client), typeof(Service));

            container.Resolve<Client>();
        }

        [Test]
        public void Inject_service_as_Func_of_Service_with_Import_contract_type()
        {
            var container = new Container().WithMefAttributedModel();
            container.RegisterExports(typeof(FuncClient), typeof(Service));

            var client = container.Resolve<FuncClient>();

            Assert.That(client.Some, Is.InstanceOf<Service>());
        }

        [Test]
        public void Inject_service_as_Lazy_of_Service_with_Import_contract_type()
        {
            var container = new Container().WithMefAttributedModel();
            container.RegisterExports(typeof(LazyClient), typeof(Service));

            var client = container.Resolve<LazyClient>();

            Assert.That(client.Some, Is.InstanceOf<Service>());
        }

        [Test]
        public void Inject_service_as_Lazy_Meta_of_Service_with_Import_contract_type()
        {
            var container = new Container().WithMefAttributedModel();
            container.RegisterExports(typeof(LazyMetaClient), typeof(Service));

            var client = container.Resolve<LazyMetaClient>();

            Assert.That(client.Some, Is.InstanceOf<Service>());
            Assert.That(client.Metadata, Is.EqualTo("blah"));
        }

        [Test]
        public void Inject_service_as_Func_Array_of_Service_with_Import_contract_type()
        {
            var container = new Container().WithMefAttributedModel();
            container.RegisterExports(typeof(FuncArrayClient), typeof(Service));

            var client = container.Resolve<FuncArrayClient>();

            Assert.That(client.Some, Is.InstanceOf<Service>());
        }

        [Test]
        public void Inject_service_as_Func_Array_of_Service_with_Import_contract_key_no_type_specified()
        {
            var container = new Container().WithMefAttributedModel();
            container.RegisterExports(typeof(FuncArrayKeyClient), typeof(Service), typeof(KeyService));

            var client = container.Resolve<FuncArrayKeyClient>();
            Assert.That(client.GetServices.Length, Is.EqualTo(1));
            Assert.That(client.GetServices[0](), Is.InstanceOf<KeyService>());
        }

        [Test]
        public void Inject_property_with_default_Import_should_work()
        {
            var container = new Container().WithMefAttributedModel();
            container.RegisterExports(typeof(PropertyClient), typeof(Service));

            var client = container.Resolve<PropertyClient>();

            Assert.That(client.Some, Is.InstanceOf<Service>());
        }

        [Test]
        public void Resolve_property_for_already_resolved_instance()
        {
            var container = new Container().WithMefAttributedModel();
            container.RegisterExports(typeof(Service));

            var client = new PropertyClient();
            container.InjectPropertiesAndFields(client);

            Assert.That(client.Some, Is.InstanceOf<Service>());
        }

        [Test]
        public void Resolving_unregistered_property_marked_by_Import_should_throw()
        {
            var container = new Container().WithMefAttributedModel();
            container.RegisterExports(typeof(Service));

            var client = new NamedPropertyClient();
            Assert.Throws<ContainerException>(() =>
                container.InjectPropertiesAndFields(client));

            Assert.That(client.Some, Is.Null);
        }

        [Test]
        public void Resolving_unregistered_property_without_attribute_model_should_not_throw_so_the_property_stays_null()
        {
            var container = new Container();
            container.Register<Service>();

            var client = new NamedPropertyClient();
            container.InjectPropertiesAndFields(client);

            Assert.That(client.Some, Is.Null);
        }

        [Test]
        public void Resolving_registered_property_with_not_assignable_type_should_Throw()
        {
            var container = new Container().WithMefAttributedModel();
            container.Register<Service>();
            container.Register<BadTypePropertyClient>();

            var ex = Assert.Throws<ContainerException>(() =>
                    container.Resolve<BadTypePropertyClient>());

            Assert.AreEqual(
                DryIoc.Error.NameOf(DryIoc.Error.UnableToResolveUnknownService),
                DryIoc.Error.NameOf(ex.Error));
        }

        [Test]
        public void Resolve_custom_generic_wrapper_marked_with_Import()
        {
            var container = new Container().WithMefAttributedModel();
            container.Register(typeof(MyWrapper<>), setup: Setup.Wrapper);

            container.RegisterExports(typeof(Service), typeof(CustomWrapperClient));

            var client = container.Resolve<CustomWrapperClient>();
            Assert.IsNotNull(client);
        }

        [Test]
        public void Could_import_property_with_internal_setter()
        {
            var container = new Container().WithMefAttributedModel();
            container.RegisterExports(typeof(ServiceWithPropWithPrivateSetter), typeof(Service));

            var service = container.Resolve<ServiceWithPropWithPrivateSetter>();

            Assert.That(service.PropWithInternalSetter, Is.InstanceOf<Service>());
        }

        [Test]
        public void When_resolving_props_and_fields_manually_required_type_should_work()
        {
            var container = new Container().WithMefAttributedModel();
            container.Register<Service>();
            container.Register<IService, AnotherService>();

            var client = container.InjectPropertiesAndFields(new ClientWithGenericWrapperProps());
            Assert.IsInstanceOf<Service>(client.GetService());
            Assert.IsNull(client.GetService2);

            client = container.InjectPropertiesAndFields(new ClientWithGenericWrapperProps(),
                nameof(ClientWithGenericWrapperProps.GetService2));
            Assert.IsInstanceOf<AnotherService>(client.GetService2());
            Assert.IsNull(client.GetService);
        }

        #region CUT

        [ExportMany, WithMetadata("blah")]
        public class Service : IService { }

        [Export]
        public class Client
        {
            public IService Some { get; set; }

            public Client([Import(typeof(Service))] IService service)
            {
                Some = service;
            }
        }

        [Export]
        public class FuncClient
        {
            public IService Some { get; set; }

            public FuncClient([Import(typeof(Service))] Func<IService> getService)
            {
                Some = getService();
            }
        }

        [Export]
        public class LazyClient
        {
            public IService Some { get; set; }

            public LazyClient([Import(typeof(Service))] Lazy<IService> getService)
            {
                Some = getService.Value;
            }
        }

        [Export]
        public class LazyMetaClient
        {
            public IService Some { get; set; }
            public string Metadata { get; set; }

            public LazyMetaClient([Import(typeof(Service))] Lazy<Meta<IService, string>> getService)
            {
                Some = getService.Value.Value;
                Metadata = getService.Value.Metadata;
            }
        }

        [Export]
        public class FuncArrayClient
        {
            public IService Some { get; set; }

            public FuncArrayClient([Import(typeof(Service))]Func<IService>[] getService)
            {
                Some = getService[0]();
            }
        }

        [Export("k", typeof(IService))]
        public class KeyService : IService { }

        [Export, TransientReuse]
        public class FuncArrayKeyClient
        {
            public Func<IService>[] GetServices { get; private set; }

            public FuncArrayKeyClient([Import("k")]Func<IService>[] getServices)
            {
                GetServices = getServices;
            }
        }

        [Export]
        public class PropertyClient
        {
            [Import(typeof(Service))]
            public IService Some { get; set; }
        }

        [Export]
        public class NamedPropertyClient
        {
            [Import("k", typeof(Service))]
            public IService Some { get; set; }
        }

        [Export]
        public class BadTypePropertyClient
        {
            [Import(typeof(BadType))]
            public IService Some { get; set; }

            public class BadType { }
        }

        [Export]
        public class CustomWrapperClient
        {
            [Import(typeof(Service))]
            public MyWrapper<IService> Some { get; set; }
        }

        public class MyWrapper<T>
        {
            public T Value { get; set; }

            public MyWrapper(T value)
            {
                Value = value;
            }
        }

        [Export]
        public class ServiceWithPropWithPrivateSetter
        {
            // ReSharper disable UnusedAutoPropertyAccessor.Local
            [Import]
            public IService PropWithInternalSetter { get; internal set; }
            // ReSharper restore UnusedAutoPropertyAccessor.Local
        }

        internal class ClientWithGenericWrapperProps
        {
            [Import(typeof(Service))]
            public Func<IService> GetService { get; set; }

            public Func<IService> GetService2 { get; set; }
        }

        #endregion
    }
}
