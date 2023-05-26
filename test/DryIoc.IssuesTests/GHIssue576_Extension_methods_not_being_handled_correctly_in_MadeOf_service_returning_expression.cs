using System;
using NUnit.Framework;

namespace DryIoc.IssuesTests
{
    [TestFixture]
    public class GHIssue576_Extension_methods_not_being_handled_correctly_in_MadeOf_service_returning_expression : ITest
    {
        public int Run()
        {
            Test_factory_extension_method();
            Test_factory_extension_method_for_the_factory_with_the_service_key();

            Test_factory_extension_method_GHIssue577();
            return 3;
        }

        [Test]
        public void Test_factory_extension_method()
        {
            var container = new Container();

            var loggerFactory = new SerilogLoggerFactory();

            container.RegisterInstance<ILoggerFactory>(loggerFactory);

            container.Register(
                Made.Of(_ => ServiceInfo.Of<ILoggerFactory>(),
                    f => f.CreateLogger(Arg.Index<Type>(0)),
                    r => r.Parent.ImplementationType),
                setup: Setup.With(condition: r => r.Parent.ImplementationType != null));

            container.Register<Foo>();
            var foo = container.Resolve<Foo>();
            
            Assert.AreEqual(typeof(Foo).FullName, ((SerilogLogger)foo.Logger).TypeName);
        }

        [Test]
        public void Test_factory_extension_method_for_the_factory_with_the_service_key()
        {
            var container = new Container();

            var loggerFactory = new SerilogLoggerFactory();

            container.RegisterInstance<ILoggerFactory>(loggerFactory, serviceKey: "obscured");

            container.Register(
                Made.Of(_ => ServiceInfo.Of<ILoggerFactory>(serviceKey: "obscured"),
                    f => f.CreateLogger(Arg.Index<Type>(0)),
                    r => r.Parent.ImplementationType),
                setup: Setup.With(condition: r => r.Parent.ImplementationType != null));

            container.Register<Foo>();
            var foo = container.Resolve<Foo>();
            
            Assert.AreEqual(typeof(Foo).FullName, ((SerilogLogger)foo.Logger).TypeName);
        }

        [Test]
        public void Test_factory_extension_method_GHIssue577()
        {
            var container = new Container();

            var loggerFactory = new SerilogLoggerFactory();

            container.RegisterInstance<ILoggerFactory>(loggerFactory);

            container.Register(
                Made.Of(_ => ServiceInfo.Of<ILoggerFactory>(),
                    f => f.CreateLogger(null)),
                setup: Setup.With(condition: r => r.Parent.ImplementationType == null));

            container.Register(
                Made.Of(_ => ServiceInfo.Of<ILoggerFactory>(),
                    f => f.CreateLogger(Arg.Index<Type>(0)),
                    r => r.Parent.ImplementationType),
                setup: Setup.With(condition: r => r.Parent.ImplementationType != null));

            container.Register<Foo>();

            var errors = container.Validate();
            // Assert.IsEmpty(errors); // todo: @fixme fails here with the root ILogger

            var log = container.Resolve<ILogger>();
            Assert.IsNull(((SerilogLogger)log).TypeName);

            var foo = container.Resolve<Foo>();
            Assert.AreEqual(typeof(Foo).FullName, ((SerilogLogger)foo.Logger).TypeName);
        }

        public sealed class Foo 
        {
            public readonly ILogger Logger;
            public Foo(ILogger logger) => Logger = logger; 
        }

        public interface ILogger {}

        public sealed class SerilogLogger : ILogger 
        {
            public readonly string TypeName;
            public SerilogLogger(string typeName) => TypeName = typeName;
        }

        public interface ILoggerFactory 
        {
            ILogger CreateLogger(string typeName);
        }

        public sealed class SerilogLoggerFactory : ILoggerFactory 
        {
            public ILogger CreateLogger(string typeName) => new SerilogLogger(typeName);
        }
    }

    public static class LoggerFactoryExt
    {
        public static GHIssue576_Extension_methods_not_being_handled_correctly_in_MadeOf_service_returning_expression.ILogger CreateLogger(
            this GHIssue576_Extension_methods_not_being_handled_correctly_in_MadeOf_service_returning_expression.ILoggerFactory factory, Type type) =>
            factory.CreateLogger(type.FullName);
    }
}
