﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DryIoc.UnitTests.CUT;
using NUnit.Framework;

namespace DryIoc.UnitTests
{
    [TestFixture]
    public class LazyEnumerableTests : ITest
    {
        public int Run()
        {
            Resolving_many_with_default_and_one_named_service_will_return_both_services();
            I_can_resolve_many_singletons();
            I_can_resolve_many_mixed_of_singletons_and_transients();
            Resolving_many_of_single_service_registered_with_delegate_should_return_this_service();
            I_can_resolve_many_open_generics();
            I_can_resolve_many_lazy_singletons();
            I_can_inject_many_as_dependency();
            Resolving_many_for_not_registered_services_should_NOT_throw_BUT_return_an_empty_items();
            When_many_is_reresolved_after_registering_another_service_Then_many_should_contain_that_service();
            When_many_dependency_is_reresolved_after_registering_another_service_Then_many_should_contain_that_service();
            I_should_be_able_to_resolve_Lazy_of_Func_of_Many();
            Resolving_from_many_services_with_matched_meta_should_throw();
            If_some_item_is_not_resolved_then_it_would_not_throw();
            CanNOT_resolve_Func_with_args_of_LazyEnumerable();
            Can_inject_Enumerable_as_LazyEnumerable_with_required_service_type();
            // When_container_is_disposed_lazy_enumerable_will_stop_working(); // Explicit
            I_can_resolve_IEnumerable_as_LazyEnumerable_with_container_rule();
            I_can_resolve_IEnumerable_as_LazyEnumerable_with_container_rule_and_required_service_type();
            return 17;
        }

        [Test]
        public void Resolving_many_with_default_and_one_named_service_will_return_both_services()
        {
            var container = new Container();
            container.Register(typeof(IService), typeof(Service));
            container.Register(typeof(IService), typeof(AnotherService), serviceKey: "another");

            var many = container.Resolve<LazyEnumerable<Func<IService>>>();

            Assert.That(many.Items.Count(), Is.EqualTo(2));
        }

        [Test]
        public void I_can_resolve_many_singletons()
        {
            var container = new Container();
            container.Register(typeof(IService), typeof(Service), Reuse.Singleton);

            var many = container.Resolve<LazyEnumerable<IService>>();

            Assert.That(many.Items.Count(), Is.EqualTo(1));
        }

        [Test]
        public void I_can_resolve_many_mixed_of_singletons_and_transients()
        {
            var container = new Container();
            container.Register(typeof(IService), typeof(Service), Reuse.Singleton);
            container.Register(typeof(IService), typeof(AnotherService), serviceKey: "another");

            var many = container.Resolve<LazyEnumerable<IService>>();

            Assert.That(many.Items.Count(), Is.EqualTo(2));
        }

        [Test]
        public void Resolving_many_of_single_service_registered_with_delegate_should_return_this_service()
        {
            var container = new Container();
            container.RegisterDelegate<IService<string>>(_ => new ClosedGenericClass());

            var many = container.Resolve<LazyEnumerable<IService<string>>>();

            Assert.That(many.Items.Single(), Is.Not.Null);
        }

        [Test]
        public void I_can_resolve_many_open_generics()
        {
            var container = new Container();
            container.Register(typeof(IService<>), typeof(Service<>), Reuse.Singleton);

            var many = container.Resolve<LazyEnumerable<IService<int>>>();

            Assert.That(many.Items.Single(), Is.InstanceOf<Service<int>>());
        }

        [Test]
        public void I_can_resolve_many_lazy_singletons()
        {
            var container = new Container();
            ServiceWithInstanceCount.InstanceCount = 0;

            container.Register(typeof(ServiceWithInstanceCount), Reuse.Singleton);

            var services = container.Resolve<LazyEnumerable<Lazy<ServiceWithInstanceCount>>>().Items;
            Assert.That(ServiceWithInstanceCount.InstanceCount, Is.EqualTo(0));

            var service = services.First().Value;
            Assert.That(service, Is.Not.Null);

            Assert.That(ServiceWithInstanceCount.InstanceCount, Is.EqualTo(1));
        }

        [Test]
        public void I_can_inject_many_as_dependency()
        {
            var container = new Container();
            container.Register(typeof(IDependency), typeof(Dependency));
            container.Register(typeof(IDependency), typeof(Dependency), serviceKey: "Foo2");
            container.Register(typeof(IService), typeof(ServiceWithManyDependencies));

            var service = (ServiceWithManyDependencies)container.Resolve<IService>();

            Assert.That(service.Foos, Is.InstanceOf<IEnumerable<IDependency>>());
        }

        [Test]
        public void Resolving_many_for_not_registered_services_should_NOT_throw_BUT_return_an_empty_items()
        {
            var container = new Container();

            var items = container.Resolve<LazyEnumerable<IService>>().Items;

            Assert.That(items.Count(), Is.EqualTo(0));
        }

        [Test]
        public void When_many_is_reresolved_after_registering_another_service_Then_many_should_contain_that_service()
        {
            var container = new Container();
            container.Register(typeof(IService), typeof(Service));
            var servicesBefore = container.Resolve<LazyEnumerable<IService>>().Items;
            Assert.That(servicesBefore.Count(), Is.EqualTo(1));

            container.Register(typeof(IService), typeof(AnotherService), serviceKey: "another");

            var servicesAfter = container.Resolve<LazyEnumerable<IService>>().Items;
            Assert.That(servicesAfter.Count(), Is.EqualTo(2));
        }

        [Test]
        public void When_many_dependency_is_reresolved_after_registering_another_service_Then_many_should_contain_that_service()
        {
            var container = new Container();
            container.Register<ServiceWithManyDependencies>();
            container.Register<IDependency, Foo1>();

            var service = container.Resolve<ServiceWithManyDependencies>();
            Assert.That(service.Foos.Count(), Is.EqualTo(1));

            container.Register<IDependency, Foo2>();

            var serviceAfter = container.Resolve<ServiceWithManyDependencies>();
            Assert.That(serviceAfter.Foos.Count(), Is.EqualTo(2));
        }

        [Test]
        public void I_should_be_able_to_resolve_Lazy_of_Func_of_Many()
        {
            var container = new Container();
            container.Register(typeof(IService), typeof(Service));
            container.Register(typeof(IService), typeof(AnotherService));

            var result = container.Resolve<Lazy<Func<LazyEnumerable<IService>>>>();

            Assert.That(result, Is.InstanceOf<Lazy<Func<LazyEnumerable<IService>>>>());
            Assert.That(result.Value.Invoke().Items.Count(), Is.EqualTo(2));
        }

        [Test]
        public void Resolving_from_many_services_with_matched_meta_should_throw()
        {
            var container = new Container();
            container.Register(typeof(IService), typeof(Service), setup: Setup.With(metadataOrFuncOfMetadata: "a"));
            container.Register(typeof(IService), typeof(AnotherService), setup: Setup.With(metadataOrFuncOfMetadata: "b"));

            var ex = Assert.Throws<ContainerException>(() =>
                container.Resolve<Meta<LazyEnumerable<IService>, string>>());

            Assert.AreEqual(
                Error.NameOf(Error.UnableToSelectFromManyRegistrationsWithMatchingMetadata),
                Error.NameOf(ex.Error));
        }

        [Test]
        public void If_some_item_is_not_resolved_then_it_would_not_throw()
        {
            var container = new Container();
            container.Register<Service>(setup: Setup.With(metadataOrFuncOfMetadata: 1));

            var servicesWithBoolMeta = container.Resolve<LazyEnumerable<Meta<Service, bool>>>().Items;
            Assert.That(servicesWithBoolMeta.Count(), Is.EqualTo(0));

            var servicesWithIntMeta = container.Resolve<LazyEnumerable<Meta<Service, int>>>().Items;
            Assert.That(servicesWithIntMeta.Count(), Is.EqualTo(1));
        }

        [Test]
        public void CanNOT_resolve_Func_with_args_of_LazyEnumerable()
        {
            var container = new Container();
            container.Register<IServiceWithParameterAndDependency, ServiceWithParameterAndDependency>();
            container.Register(typeof(Service));

            var f = container.Resolve<Func<bool, LazyEnumerable<IServiceWithParameterAndDependency>>>();
            Assert.AreEqual(true, f(true).First().Flag);
        }

        [Test]
        public void Can_inject_Enumerable_as_LazyEnumerable_with_required_service_type()
        {
            var container = new Container();
            container.Register<Child>();
            container.Register(Made.Of(() => new Man(Arg.Of<LazyEnumerable<Child>>())));

            var man = container.Resolve<Man>();
            Assert.IsInstanceOf<Child>(man.Children.FirstOrDefault());

            var expr = container.Resolve<LambdaExpression>(typeof(Man));
            StringAssert.Contains("r.ResolveMany(", expr.ToString());
        }

        public class Man
        {
            public IEnumerable<Child> Children { get; private set; }

            public Man(IEnumerable<Child> children)
            {
                Children = children;
            }
        }

        public class Child { }

        [Explicit]
        public void When_container_is_disposed_lazy_enumerable_will_stop_working()
        {
            var container = new Container();
            container.Register<Service>();
            var services = container.Resolve<LazyEnumerable<Service>>();
            var containerRef = new WeakReference(container);

            // ReSharper disable once RedundantAssignment
            container = null;
            GC.Collect();

            Assert.That(containerRef.IsAlive, Is.False);
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Assert.Throws<ContainerException>(() => { services.FirstOrDefault(); });
        }

        [Test]
        public void I_can_resolve_IEnumerable_as_LazyEnumerable_with_container_rule()
        {
            var container = new Container(rules => rules.WithResolveIEnumerableAsLazyEnumerable());

            var aas = container.Resolve<IEnumerable<A>>();
            container.Register<A>();

            Assert.IsInstanceOf<A>(aas.SingleOrDefault());
        }

        [Test]
        public void I_can_resolve_IEnumerable_as_LazyEnumerable_with_container_rule_and_required_service_type()
        {
            var container = new Container(rules => rules.WithResolveIEnumerableAsLazyEnumerable());

            var aas = container.Resolve<IEnumerable<object>>(typeof(A));
            container.Register<A>();

            Assert.IsInstanceOf<A>(aas.SingleOrDefault());
        }

        public class A { }
    }
}