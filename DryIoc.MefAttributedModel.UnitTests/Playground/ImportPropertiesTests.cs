﻿using System;
using System.Reflection;
using DryIoc.AttributedRegistration.UnitTests.CUT;
using DryIoc.MefAttributedModel;
using NUnit.Framework;

namespace DryIoc.AttributedRegistration.UnitTests.Playground
{
    [TestFixture][Ignore]
    public class ImportPropertiesTests
    {
        [Test]
        public void I_want_to_resolve_service_properties_with_import_attribute()
        {
            var container = new Container();
            container.RegisterExports(typeof(ServiceWithProperties));
            container.Register<IService, Service>();

            container.ResolutionRules.PropertiesAndFields =
                container.ResolutionRules.PropertiesAndFields.Append(ImportAll);

            var service = container.Resolve<ServiceWithProperties>();

            Assert.That(service.Property, Is.Not.Null);
        }

        [Test]
        public void It_should_NOT_throw_on_unresolved_members()
        {
            var container = new Container();
            container.RegisterExports(typeof(ServiceWithUnregistredMembers));

            container.ResolutionRules.PropertiesAndFields =
                container.ResolutionRules.PropertiesAndFields.Append(ImportAll);

            var service = container.Resolve<ServiceWithUnregistredMembers>();

            Assert.That(service, Is.Not.Null);
        }

        private static bool ImportAll(out object key, MemberInfo member, Request parent, IRegistry registry)
        {
            key = null;
            var memberType = member.GetMemberType();
            return registry.IsRegistered(memberType);
        }
    }

    [ExportAll, ImportMembers]
    public class ServiceWithProperties
    {
        public IService Property { get; set; }
    }

    [ExportAll, ImportMembers]
    public class ServiceWithUnregistredMembers
    {
        public int Count;
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class ImportMembersAttribute : Attribute
    {
    }
}
