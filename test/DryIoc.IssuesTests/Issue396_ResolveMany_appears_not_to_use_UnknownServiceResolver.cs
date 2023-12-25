﻿using System.Linq;
using NUnit.Framework;

namespace DryIoc.IssuesTests
{
    [TestFixture]
    public class Issue396_ResolveMany_appears_not_to_use_UnknownServiceResolver : ITest
    {
        public int Run()
        {
            Can_ResolveMany_of_not_registered_service_interface();
            Can_ResolveMany_of_not_registered_service_generic_interface_without_scanning_order();
            Selects_only_valid_non_generic_impl_for_non_generic_service();
            I_should_be_able_to_specify_reuse();
            return 4;
        }

        [Test]
        public void Can_ResolveMany_of_not_registered_service_interface()
        {
            var container = new Container()
                .WithAutoFallbackDynamicRegistrations(typeof(CustomRegistrationA), typeof(CustomRegistrationB));

            var xs = container.ResolveMany<ICustomRegistration>();

            CollectionAssert.AreEquivalent(new[] { typeof(CustomRegistrationA), typeof(CustomRegistrationB) }, xs.Select(_ => _.GetType()));
        }

        public interface ICustomRegistration { }

        public class CustomRegistrationA : ICustomRegistration { }

        public class CustomRegistrationB : ICustomRegistration { }

        [Test] // Scanning or registration order does not make sense for dynamic registrations
        public void Can_ResolveMany_of_not_registered_service_generic_interface_without_scanning_order()
        {
            var implTypes = new[] {
                typeof(CustomRegistrationA<>),
                typeof(CustomRegistrationAStr),
                typeof(CustomRegistrationB<>) };

            var container = new Container().WithAutoFallbackDynamicRegistrations(implTypes);

            var xs = container.ResolveMany<ICustomRegistration<string>>().ToArray();

            Assert.AreEqual(3, xs.Length);
            Assert.IsInstanceOf<CustomRegistrationAStr>(xs[0]);
            Assert.IsInstanceOf<CustomRegistrationA<string>>(xs[1]);
            Assert.IsInstanceOf<CustomRegistrationB<string>>(xs[2]);
        }

        public interface ICustomRegistration<T> { }

        public class CustomRegistrationA<T> : ICustomRegistration<T> { }

        public class CustomRegistrationB<T> : ICustomRegistration<T> { }

        public class CustomRegistrationAStr : ICustomRegistration<string> { }

        [Test]
        public void Selects_only_valid_non_generic_impl_for_non_generic_service()
        {
            var implTypes = new[] { typeof(CustomRegistrationA<>), typeof(CustomRegistrationB) };

            var container = new Container().WithAutoFallbackDynamicRegistrations(implTypes);

            var xs = container.ResolveMany<ICustomRegistration>().ToArray();

            Assert.AreEqual(1, xs.Length);
            Assert.IsInstanceOf<CustomRegistrationB>(xs[0]);
        }


        [Test]
        public void I_should_be_able_to_specify_reuse()
        {
            var container = new Container().WithAutoFallbackDynamicRegistrations(
                Reuse.Singleton, typeof(CustomRegistrationA<>), typeof(CustomRegistrationB<>));

            var x1 = container.ResolveMany<ICustomRegistration<string>>().ToArray();
            var x2 = container.ResolveMany<ICustomRegistration<string>>().ToArray();

            Assert.AreSame(x1[0], x2[0]);
        }
    }
}
