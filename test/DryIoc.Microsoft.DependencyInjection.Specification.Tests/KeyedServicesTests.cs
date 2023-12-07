using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Specification;

// uncomment when I want to copy some test here for testing.
using Microsoft.Extensions.DependencyInjection.Specification.Fakes;
using Xunit;

namespace DryIoc.Microsoft.DependencyInjection.Specification.Tests
{
    public class KeyedServicesTests : KeyedDependencyInjectionSpecificationTests
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection collection) =>
            new DryIocServiceProviderFactory().CreateBuilder(collection).BuildServiceProvider();

        [Fact]
        public void ResolveKeyedServiceTransientFactory_COPY()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddKeyedTransient<IService>("service1", (sp, key) => new Service(key as string));

            var provider = CreateServiceProvider(serviceCollection);

            Assert.Null(provider.GetService<IService>());

            var first = provider.GetKeyedService<IService>("service1");
            var second = provider.GetKeyedService<IService>("service1");

            Assert.NotSame(first, second);
            Assert.Equal("service1", first.ToString());
            Assert.Equal("service1", second.ToString());
        }

        [Fact]
        public void ResolveKeyedServiceSingletonInstanceWithKeyedParameter_COPY()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddKeyedSingleton<IService, Service>("service1");
            serviceCollection.AddKeyedSingleton<IService, Service>("service2");
            serviceCollection.AddSingleton<OtherService>();

            var provider = CreateServiceProvider(serviceCollection);

            Assert.Null(provider.GetService<IService>());
            var svc = provider.GetService<OtherService>();
            Assert.NotNull(svc);
            Assert.Equal("service1", svc.Service1.ToString());
            Assert.Equal("service2", svc.Service2.ToString());
        }

        // todo: @wip test with open-generic keyed service
        [Fact]
        public void ResolveKeyedServiceSingletonFactoryWithAnyKey_COPY()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddKeyedSingleton<IService>(KeyedService.AnyKey, (_, key) => new Service((string)key));

            var provider = CreateServiceProvider(serviceCollection);

            Assert.Null(provider.GetService<IService>());

            for (var i = 0; i < 3; i++)
            {
                var key = "service" + i;
                var s1 = provider.GetKeyedService<IService>(key);
                var s2 = provider.GetKeyedService<IService>(key);
                Assert.Same(s1, s2);
                Assert.Equal(key, s1.ToString());
            }
        }

        internal interface IService { }

        internal class Service : IService
        {
            private readonly string _id;

            public Service() => _id = Guid.NewGuid().ToString();

            public Service([ServiceKey] string id) => _id = id;

            public override string ToString() => _id;
        }

        internal class OtherService
        {
            public OtherService(
                [FromKeyedServices("service1")] IService service1,
                [FromKeyedServices("service2")] IService service2)
            {
                Service1 = service1;
                Service2 = service2;
            }

            public IService Service1 { get; }

            public IService Service2 { get; }
        }
    }
}
