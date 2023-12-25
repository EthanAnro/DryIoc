using System.ComponentModel.Composition;
using DryIoc.MefAttributedModel;
using NUnit.Framework;

namespace DryIoc.IssuesTests
{
    [TestFixture]
    public class Issue394_Reimporting_services : ITest
    {
        public int Run()
        {
            InjectPropertiesAndFields_imports_new_services_into_resolved_singleton();
            InjectPropertiesAndFields_of_new_imports_for_external_instance_via_ClearCache();
            Resolve_new_imports_for_transient_via_ClearCache();
            Resolve_new_imports_for_singleton_via_WithoutSingletonsAndCache();
            return 4;
        }

        [Test]
        public void InjectPropertiesAndFields_imports_new_services_into_resolved_singleton()
        {
            // registered on application startup
            var container = new Container().WithMef();

            container.Register<Aggregator>(Reuse.Singleton);
            container.Register<IAggregatee, Agg1>(Reuse.Transient);

            // used later
            var aggregator = container.Resolve<Aggregator>();
            Assert.AreEqual(1, aggregator.Aggregatees.Length);

            // registered new service and re-imported
            container.Register<IAggregatee, Agg2>(Reuse.Transient);
            container.InjectPropertiesAndFields(aggregator);
            Assert.AreEqual(2, aggregator.Aggregatees.Length);
        }

        [Test]
        public void InjectPropertiesAndFields_of_new_imports_for_external_instance_via_ClearCache()
        {
            // registered on application startup
            var container = new Container().WithMef();

            container.Register<IAggregatee, Agg1>();

            // used later
            var aggregator = new Aggregator();
            container.InjectPropertiesAndFields(aggregator);
            Assert.AreEqual(1, aggregator.Aggregatees.Length);

            // registered new service and re-imported
            container.Register<IAggregatee, Agg2>();

            // required to clear cache
            container.ClearCache<IAggregatee[]>();
            container.InjectPropertiesAndFields(aggregator);
            Assert.AreEqual(2, aggregator.Aggregatees.Length);

            // registered new service and re-imported
            container.Register<IAggregatee, Agg3>();

            // required to clear cache
            container.ClearCache<IAggregatee[]>();
            container.InjectPropertiesAndFields(aggregator);
            Assert.AreEqual(3, aggregator.Aggregatees.Length);
        }

        [Test]
        public void Resolve_new_imports_for_transient_via_ClearCache()
        {
            // registered on application startup
            var container = new Container().WithMef()
                .With(r => r.WithDefaultReuse(Reuse.Transient));

            container.Register<Aggregator>();
            container.Register<IAggregatee, Agg1>();

            // used later
            var aggregator = container.Resolve<Aggregator>();
            Assert.AreEqual(1, aggregator.Aggregatees.Length);

            // registered new service and re-imported
            container.Register<IAggregatee, Agg2>();

            container.ClearCache<Aggregator>();
            aggregator = container.Resolve<Aggregator>();
            Assert.AreEqual(2, aggregator.Aggregatees.Length);

            // registered new service and re-imported
            container.Register<IAggregatee, Agg3>();
            container.ClearCache<Aggregator>();
            aggregator = container.Resolve<Aggregator>();
            Assert.AreEqual(3, aggregator.Aggregatees.Length);
        }

        [Test]
        public void Resolve_new_imports_for_singleton_via_WithoutSingletonsAndCache()
        {
            // registered on application startup
            var container = new Container().WithMef();

            container.Register<Aggregator>();
            container.Register<IAggregatee, Agg1>();

            // used later
            var aggregator = container.Resolve<Aggregator>();
            Assert.AreEqual(1, aggregator.Aggregatees.Length);

            // registered new service and re-imported
            container.Register<IAggregatee, Agg2>();
            container = container.WithoutSingletonsAndCache();
            aggregator = container.Resolve<Aggregator>();
            Assert.AreEqual(2, aggregator.Aggregatees.Length);

            // registered new service and re-imported
            container.Register<IAggregatee, Agg3>();
            container = container.WithoutSingletonsAndCache();
            aggregator = container.Resolve<Aggregator>();
            Assert.AreEqual(3, aggregator.Aggregatees.Length);
        }

        public class Aggregator
        {
            [ImportMany]
            public IAggregatee[] Aggregatees { get; set; }
        }

        public interface IAggregatee { }

        public class Agg1 : IAggregatee { }

        public class Agg2 : IAggregatee { }

        public class Agg3 : IAggregatee { }
    }
}
