﻿using System.Linq.Expressions;
using DryIoc.UnitTests.CUT;
using NUnit.Framework;

namespace DryIoc.UnitTests
{
    public class DiagnosticsTests : ITest
    {
        public int Run()
        {
            Factory_expression_returns_expression_used_by_Container_to_create_service();
            return 1;
        }

        [Test]
        public void Factory_expression_returns_expression_used_by_Container_to_create_service()
        {
            var container = new Container();
            container.Register<ServiceWithDependency>();
            container.Register<IDependency, Dependency>(Reuse.Singleton);

            var service = container.Resolve<LambdaExpression>(typeof(ServiceWithDependency));

            StringAssert.Contains("=> new ServiceWithDependency(", service.ToString());
        }
    }
}