﻿using System;
using System.Collections.Generic;
using System.Linq;
using DryIoc.UnitTests.CUT;
using NUnit.Framework;

namespace DryIoc.UnitTests
{
    [TestFixture]
    public class ResolveManyTests : ITest
    {
        public int Run()
        {
            Return_empty_collection_for_registered_service();
            Return_one_item_collection();
            Return_two_items_in_order_of_registration();
            Aware_of_newly_registered_service();
            Result_enumerable_Behavior_Not_aware_of_newly_registered_services();
            Result_enumerable_Behavior_aware_of_newly_registered_services();
            Newly_registered_services_still_could_be_returned_by_resolving_as_dynamic_after_fixed();
            Return_enumerable_of_object_is_possible_with_required_service_type();
            Return_enumerable_of_object_is_possible_with_required_service_type_is_fine_fixed_view_too();
            Should_return_empty_collection_if_required_service_is_not_assignable_collection_item_type();
            Could_resolve_collection_of_generic_wrappers_if_needed();
            Can_specify_service_key_to_resolve_many();
            Should_throw_on_undetermined_dependency();
            return 13;
        }

        [Test]
        public void Return_empty_collection_for_registered_service()
        {
            var container = new Container();

            var items = container.ResolveMany<IService>();

            Assert.That(items.Count(), Is.EqualTo(0));
        }

        [Test]
        public void Return_one_item_collection()
        {
            var container = new Container();
            container.Register<IService, Service>();

            var items = container.ResolveMany<IService>().ToArray();

            Assert.That(items.Length, Is.EqualTo(1));
            Assert.That(items[0], Is.InstanceOf<Service>());
        }

        [Test]
        public void Return_two_items_in_order_of_registration()
        {
            var container = new Container();
            container.Register<IService, Service>();
            container.Register<IService, AnotherService>();

            var items = container.ResolveMany<IService>().ToArray();

            Assert.That(items.Length, Is.EqualTo(2));
            Assert.That(items[0], Is.InstanceOf<Service>());
            Assert.That(items[1], Is.InstanceOf<AnotherService>());
        }

        [Test]
        public void Aware_of_newly_registered_service()
        {
            var container = new Container();

            var items = container.ResolveMany<IService>().ToArray();
            Assert.That(items.Count(), Is.EqualTo(0));

            container.Register<IService, Service>();
            items = container.ResolveMany<IService>().ToArray();

            Assert.That(items.Length, Is.EqualTo(1));
            Assert.That(items[0], Is.InstanceOf<Service>());
        }

        [Test]
        public void Result_enumerable_Behavior_Not_aware_of_newly_registered_services()
        {
            var container = new Container();

            var items = container.ResolveMany<IService>(behavior: ResolveManyBehavior.AsFixedArray);
            Assert.AreEqual(0, items.Count());

            container.Register<IService, Service>();
            Assert.AreEqual(0, items.Count());
        }

        [Test]
        public void Result_enumerable_Behavior_aware_of_newly_registered_services()
        {
            var container = new Container();

            var items = container.ResolveMany<IService>(behavior: ResolveManyBehavior.AsLazyEnumerable);
            Assert.AreEqual(0, items.Count());

            container.Register<IService, Service>();
            Assert.AreEqual(1, items.Count());
        }

        [Test]
        public void Newly_registered_services_still_could_be_returned_by_resolving_as_dynamic_after_fixed()
        {
            var container = new Container();

            var items = container.ResolveMany<IService>(behavior: ResolveManyBehavior.AsFixedArray).ToArray();
            Assert.That(items.Count(), Is.EqualTo(0));

            container.Register<IService, Service>();
            items = container.ResolveMany<IService>().ToArray();
            Assert.That(items.Count(), Is.EqualTo(1));
        }

        [Test]
        public void Return_enumerable_of_object_is_possible_with_required_service_type()
        {
            var container = new Container();
            container.Register<IService, Service>(serviceKey: 1);
            container.Register<IService, AnotherService>(serviceKey: '1');

            var result = container.ResolveMany(typeof(IService));
            var items = result.ToArray();

            Assert.That(items.Length, Is.EqualTo(2));
            Assert.That(items[0], Is.InstanceOf<Service>());
            Assert.That(items[1], Is.InstanceOf<AnotherService>());
        }

        [Test]
        public void Return_enumerable_of_object_is_possible_with_required_service_type_is_fine_fixed_view_too()
        {
            var container = new Container();
            container.Register<IService, Service>(serviceKey: 1);
            container.Register<IService, AnotherService>(serviceKey: '1');

            var items = container.ResolveMany(typeof(IService), ResolveManyBehavior.AsFixedArray).ToArray();

            Assert.That(items.Length, Is.EqualTo(2));
            Assert.That(items[0], Is.InstanceOf<Service>());
            Assert.That(items[1], Is.InstanceOf<AnotherService>());
        }

        [Test]
        public void Should_return_empty_collection_if_required_service_is_not_assignable_collection_item_type()
        {
            var container = new Container();
            container.Register<Service>();

            var items = container.ResolveMany<AnotherService>(typeof(Service));

            Assert.IsFalse(items.Any());
        }

        [Test]
        public void Could_resolve_collection_of_generic_wrappers_if_needed()
        {
            var container = new Container();
            container.Register<Service>(serviceKey: "first");

            var items = container.ResolveMany<Func<KeyValuePair<string, object>>>(typeof(Service)).ToArray();

            Assert.That(items.Length, Is.EqualTo(1));
            Assert.That(items[0]().Key, Is.EqualTo("first"));
            Assert.That(items[0]().Value, Is.InstanceOf<Service>());
        }

        [Test]
        public void Can_specify_service_key_to_resolve_many()
        {
            var container = new Container();
            container.Register<IService, Service>(serviceKey: "first");
            container.Register<IService, AnotherService>();

            var service = container.ResolveMany<IService>(serviceKey: "first").First();
            Assert.IsNotNull(service);

            var services = container.ResolveMany<IService>();
            Assert.AreEqual(2, services.Count());

            var noServices = container.ResolveMany<IService>(serviceKey: "wrong");
            Assert.AreEqual(0, noServices.Count());
        }

        [Test]
        public void Should_throw_on_undetermined_dependency()
        {
            var container = new Container();

            container.Register<K>();
            container.Register<F>(Reuse.InCurrentNamedScope(1));
            container.Register<F, FF>(Reuse.InCurrentScope);

            var scope = container.OpenScope(1);

            var ex = Assert.Throws<ContainerException>(() => 
                scope.ResolveMany<K>().First());

            Assert.AreEqual(Error.NameOf(Error.ExpectedSingleDefaultFactory), Error.NameOf(ex.Error));
        }

        public class K
        {
            public K(F f)
            {
                F = f;
            }

            public F F { get; private set; }
        }

        public class F { }
        public class FF : F { }

    }
}
