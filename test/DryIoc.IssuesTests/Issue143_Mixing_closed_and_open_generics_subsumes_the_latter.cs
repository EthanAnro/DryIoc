﻿using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace DryIoc.IssuesTests
{
    [TestFixture]
    public class Issue143_Mixing_closed_and_open_generics_subsumes_the_latter : ITest
    {
        public int Run()
        {
            Given_registered_close_and_open_generic_I_can_resolve_open_generic_with_required_servic_type();
            Given_registered_close_and_open_generic_I_can_inject_open_generic_with_required_servic_type();
            Should_throw_if_required_open_generic_is_not_implements_service_type();
            Resolving_many_as_array_should_return_both_close_and_open_generic();
            Resolving_open_generic_composite_should_work();
            Resolving_open_generic_composite_should_work_with_ResolveMany();
            Resolving_open_generic_composite_as_ResolveMany_should_work();
            return 7;
        }

        interface I<T> { }

        class C : I<int> { }

        class S : I<string> { }

        class G<T> : I<T> { }

        class ConsumerOfI
        {
            public I<string> Istr { get; private set; }

            public ConsumerOfI(I<string> istr)
            {
                Istr = istr;
            }
        }

        [Test]
        public void Given_registered_close_and_open_generic_I_can_resolve_open_generic_with_required_servic_type()
        {
            var c = new Container();
            c.Register(typeof(I<int>), typeof(C));
            c.Register(typeof(I<>), typeof(G<>));

            var i = c.Resolve<I<int>>(typeof(I<>));

            Assert.IsInstanceOf<G<int>>(i);
        }

        [Test]
        public void Given_registered_close_and_open_generic_I_can_inject_open_generic_with_required_servic_type()
        {
            var c = new Container();
            c.Register(typeof(I<string>), typeof(S));
            c.Register(typeof(I<>), typeof(G<>));
            c.Register<ConsumerOfI>(made: Parameters.Of.Type<I<string>>(typeof(I<>)));

            var i = c.Resolve<ConsumerOfI>();

            Assert.IsInstanceOf<G<string>>(i.Istr);
        }

        class Unrelated<T> { }

        [Test]
        public void Should_throw_if_required_open_generic_is_not_implements_service_type()
        {
            var c = new Container();
            c.Register(typeof(I<int>), typeof(C));
            c.Register(typeof(I<>), typeof(G<>));

            var ex = Assert.Throws<ContainerException>(() => 
                c.Resolve<I<int>>(typeof(Unrelated<>)));

            Assert.AreEqual(
                Error.NameOf(Error.UnableToResolveFromRegisteredServices),
                Error.NameOf(ex.Error));
        }

        [Test]
        public void Resolving_many_as_array_should_return_both_close_and_open_generic()
        {
            var c = new Container();
            c.Register(typeof(I<int>), typeof(C));
            c.Register(typeof(I<>), typeof(G<>));

            var i = c.ResolveMany<I<int>>(behavior: ResolveManyBehavior.AsFixedArray);
            Assert.AreEqual(2, i.Count());
        }

        [Test]
        public void Resolving_open_generic_composite_should_work()
        {
            var container = new Container();

            container.Register<I<int>, C>();
            container.Register(typeof(I<>), typeof(M<>));

            var iis = container.Resolve<I<int>[]>();

            Assert.AreEqual(2, iis.Length);
            Assert.IsInstanceOf<C>(iis.OfType<M<int>>().Single().Iis.Single());
        }

        [Test]
        public void Resolving_open_generic_composite_should_work_with_ResolveMany()
        {
            var container = new Container(rules => rules.WithResolveIEnumerableAsLazyEnumerable());

            container.Register(typeof(I<int>), typeof(C));
            container.Register(typeof(I<>), typeof(M<>));

            var ies = container.Resolve<IEnumerable<I<int>>>().ToArray();

            Assert.AreEqual(2, ies.Length);
            Assert.IsInstanceOf<C>(ies.OfType<M<int>>().Single().Iis.Single());
        }

        [Test]
        public void Resolving_open_generic_composite_as_ResolveMany_should_work()
        {
            var container = new Container();

            container.Register(typeof(I<int>), typeof(C));
            container.Register(typeof(I<>), typeof(M<>));

            var ies = container.ResolveMany<I<int>>().ToArray();

            Assert.AreEqual(2, ies.Length);
            Assert.IsInstanceOf<C>(ies.OfType<M<int>>().Single().Iis.Single());
        }

        class M<T> : I<T>
        {
            public I<T>[] Iis { get; private set; }

            public M(IEnumerable<I<T>> iis)
            {
                Iis = iis.ToArray();
            }
        }
    }
}
