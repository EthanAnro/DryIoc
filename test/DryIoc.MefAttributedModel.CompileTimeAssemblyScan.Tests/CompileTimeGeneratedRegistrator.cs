namespace DryIoc.MefAttributedModel.CompileTimeAssemblyScan.Tests
{
    using System;

    public static class CompileTimeGeneratedRegistrator
    {
        public static readonly ExportedRegistrationInfo[] Registrations =
        {

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Service),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Service), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AnotherService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AnotherService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ITransientService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SingletonService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ISingletonService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Singleton },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SingletonOpenGenericService<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IOpenGenericService<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOpenGenericService<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOpenGenericService<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OpenGenericServiceWithTwoParameters<,>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OpenGenericServiceWithTwoParameters<,>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DependentService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DependentService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OneTransientService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMultipleImplementations), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "DisplayName", "One" },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.ExportWithDisplayNameAttribute", new DryIoc.MefAttributedModel.UnitTests.CUT.ExportWithDisplayNameAttribute(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMultipleImplementations), "One") },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.ExportWithDisplayNameAttribute.ToCode()", "new DryIoc.MefAttributedModel.UnitTests.CUT.ExportWithDisplayNameAttribute(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMultipleImplentations), \"One\")" },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AnotherTransientService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMultipleImplementations), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OneServiceWithMetadata),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMetadata), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "DisplayName", "Up" },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.ExportWithDisplayNameAttribute", new DryIoc.MefAttributedModel.UnitTests.CUT.ExportWithDisplayNameAttribute(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMetadata), "Up") },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.ExportWithDisplayNameAttribute.ToCode()", "new DryIoc.MefAttributedModel.UnitTests.CUT.ExportWithDisplayNameAttribute(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMetadata), \"Up\")" },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AnotherServiceWithMetadata),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMetadata), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "DisplayName", "Down" },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.ExportWithDisplayNameAttribute", new DryIoc.MefAttributedModel.UnitTests.CUT.ExportWithDisplayNameAttribute(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMetadata), "Down") },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.ExportWithDisplayNameAttribute.ToCode()", "new DryIoc.MefAttributedModel.UnitTests.CUT.ExportWithDisplayNameAttribute(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMetadata), \"Down\")" },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.YetAnotherServiceWithMetadata),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMetadata), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "DisplayName", "Elsewhere" },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.ViewWithAttribute", new DryIoc.MefAttributedModel.UnitTests.CUT.ViewWithAttribute() { DisplayName = "Elsewhere" } },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.ViewWithAttribute.ToCode()", "new DryIoc.MefAttributedModel.UnitTests.CUT.ViewWithAttribute() { DisplayName = \"Elsewhere\" }" },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithMultipleConstructors),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithMultipleConstructors), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithMultipleConstructorsAndOneImporting),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithMultipleConstructorsAndOneImporting), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SingleServiceWithMetadata),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SingleServiceWithMetadata), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "@ExportMetadataDefaultKey", 1 },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithImportedCtorParameter),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithImportedCtorParameter), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamedService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AnotherNamedService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamedService), "blah", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DbMan),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DbMan), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ISomeDb), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IAnotherDb), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DbMan<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DbMan<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ISomeDb<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UseLazyEnumerable),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UseLazyEnumerable), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Singleton },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Me),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Me), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDepClient),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDepClient), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDep),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDep), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = true,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject1),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IExportConditionInterface), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = true,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForImportCondition1ParentAttribute)
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IExportConditionInterface), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForImportCondition2ParentAttribute)
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject3),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IExportConditionInterface), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = true,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForImportCondition3ParentAttribute)
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject1),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject1), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject2), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject3),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject3), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.A),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.A), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = true,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.B),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.B), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithReuseAttribute),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithReuseAttribute), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithSingletonReuse),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithSingletonReuse), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Singleton },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithCurrentScopeReuse),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithCurrentScopeReuse), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Scoped },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithResolutionScopeReuse),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithResolutionScopeReuse), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.ResolutionScope },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UserOfServiceWithResolutionScopeReuse),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UserOfServiceWithResolutionScopeReuse), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = true,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithNamedCurrentScope),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithNamedCurrentScope), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Scoped, ScopeName = "ScopeA" },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WeaklyReferencedService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WeaklyReferencedService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = true,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PreventDisposalService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PreventDisposalService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = true,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DTUser),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DTUser), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Singleton },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DT),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DT), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = true,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DT2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DT2), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = true,
        TrackDisposableTransient = true,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.A1),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.A1), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IntItem),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IntItem), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IItem<System.Int32>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Item<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Item<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IItem<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.CompositeItem<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.CompositeItem<>), "root", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IItem<>), "root", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AllOpts),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IAllOpts), "a", DryIoc.IfAlreadyRegistered.Keep),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Scoped },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AllOpts2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IAllOpts), "a", DryIoc.IfAlreadyRegistered.Keep),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Scoped },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedScopeService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedScopeService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Scoped, ScopeName = "a" },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiCtorDep),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiCtorDep), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiCtorSample),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiCtorSample), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithMetaKeyValue),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithMetaKeyValue), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "a", 1 },
            { "b", 2 },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithWithMetadataOnlyKeyValue),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithWithMetadataOnlyKeyValue), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "a", 1 },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithExportMetadataOnlyKeyValue),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithExportMetadataOnlyKeyValue), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "b", 2 },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PrintToCodeExample),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PrintToCodeExample), 1, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IPrintToCode), 1, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Singleton },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PrintToCodeNoCreationPolicyExample),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PrintToCodeNoCreationPolicyExample), 2, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IPrintToCode), 2, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ClientWithPrimitiveParameter),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ClientWithPrimitiveParameter), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ClientWithServiceAndPrimitiveProperty),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ClientWithServiceAndPrimitiveProperty), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FastHandler),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FastHandler), "fast", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), "fast", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "@ExportMetadataDefaultKey", 2 },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SlowHandler),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SlowHandler), "slow", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), "slow", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "@ExportMetadataDefaultKey", 1 },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandler),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandler), "transact", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), "transact", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "@ExportMetadataDefaultKey", 1 },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LoggingHandlerDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LoggingHandlerDecorator), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
        Decorator = new DecoratorInfo { DecoratedServiceKey = "slow", Order = 0, UseDecorateeReuse = false }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RetryHandlerDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RetryHandlerDecorator), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
        Decorator = new DecoratorInfo { DecoratedServiceKey = null, Order = 0, UseDecorateeReuse = false }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandlerDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandlerDecorator), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
        Decorator = new DecoratorInfo { DecoratedServiceKey = "transact", Order = 0, UseDecorateeReuse = false }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.CustomHandlerDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.CustomHandlerDecorator.ForSlowHandler),
        Decorator = new DecoratorInfo { DecoratedServiceKey = null, Order = 0, UseDecorateeReuse = false }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DecoratorWithFastHandlerImport),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DecoratorWithFastHandlerImport), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
        Decorator = new DecoratorInfo { DecoratedServiceKey = null, Order = 0, UseDecorateeReuse = false }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BlahHandler),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Blah, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FoohHandler),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FoohHandler), DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Fooh, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Fooh, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FoohDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FoohDecorator), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
        Decorator = new DecoratorInfo { DecoratedServiceKey = DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Fooh, Order = 0, UseDecorateeReuse = false }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DecoratedResult),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDecoratedResult), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FuncDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDecoratedResult), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
        Decorator = new DecoratorInfo { DecoratedServiceKey = null, Order = 0, UseDecorateeReuse = false }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DynamicDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDecoratedResult), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = true,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
        Decorator = new DecoratorInfo { DecoratedServiceKey = null, Order = 0, UseDecorateeReuse = false }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceAReal),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceA), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceADecoratorInner),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceA), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
        Decorator = new DecoratorInfo { DecoratedServiceKey = null, Order = 1, UseDecorateeReuse = false }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceADecoratorOuter),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceA), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
        Decorator = new DecoratorInfo { DecoratedServiceKey = null, Order = 2, UseDecorateeReuse = false }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FactoryConsumer),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FactoryConsumer), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.One),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.One), "one", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.One), "two", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DryFactory<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DryFactory<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IFactory<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Wrapper,
        ConditionType = null,
        Wrapper = new WrapperInfo { WrappedServiceTypeArgIndex = -1, AlwaysWrapsRequiredServiceType = false }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FactoryWithArgsConsumer),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FactoryWithArgsConsumer), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Two),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Two), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DryFactory<,>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DryFactory<,>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IFactory<,>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Wrapper,
        ConditionType = null,
        Wrapper = new WrapperInfo { WrappedServiceTypeArgIndex = 1, AlwaysWrapsRequiredServiceType = false }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OrangeFactory),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OrangeFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OrangeFactory),
            MemberName = "Create",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OrangeFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory),
            MemberName = "CreateOrange",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Apple),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Apple), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory),
            MemberName = "CreateApple",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange), "orange", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory),
            MemberName = "CreateOrange",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Apple),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Apple), "apple", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory),
            MemberName = "CreateApple",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOrangeFactory),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOrangeFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOrangeFactory),
            MemberName = "Create",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOrangeFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FuncFactory),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FuncFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(System.Func<System.String, DryIoc.MefAttributedModel.UnitTests.CUT.Orange>),
        Exports = new[] {
            new ExportInfo(typeof(System.Func<System.String, DryIoc.MefAttributedModel.UnitTests.CUT.Orange>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FuncFactory),
            MemberName = "Create",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FuncFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BirdFactory),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BirdFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Duck),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Duck), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BirdFactory),
            MemberName = "GetDuck"
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Chicken),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Chicken), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BirdFactory),
            MemberName = "Chicken"
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Chicken),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Chicken), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.StaticBirdFactory),
            MemberName = "Chicken"
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Duck),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Duck), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.StaticBirdFactory),
            MemberName = "Duck"
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyedFactoryWithString),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyedFactoryWithString), "hey", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(System.String),
        Exports = new[] {
            new ExportInfo(typeof(System.String), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyedFactoryWithString),
            MemberName = "GetValue",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyedFactoryWithString), "hey", DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyClient),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyClient), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IService), DryIoc.MefAttributedModel.UnitTests.CUT.ServiceKey.One, DryIoc.IfAlreadyRegistered.Throw),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OtherKeyService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OtherKeyService), DryIoc.MefAttributedModel.UnitTests.CUT.ServiceKey.OtherOne, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IService), DryIoc.MefAttributedModel.UnitTests.CUT.ServiceKey.OtherOne, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithBothTheSameExports),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithBothTheSameExports), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedOne),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedOne), "blah", DryIoc.IfAlreadyRegistered.Keep),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamed), "blah", DryIoc.IfAlreadyRegistered.Keep),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IOne), "blah", DryIoc.IfAlreadyRegistered.Keep),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BothExportManyAndExport),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamed), "named", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BothExportManyAndExport), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamed), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IOne), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NativeUser),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NativeUser), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.HomeUser),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.HomeUser), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithFieldAndProperty),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithFieldAndProperty), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OneDependsOnExternalTool),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OneDependsOnExternalTool), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OtherDependsOnExternalTool),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OtherDependsOnExternalTool), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithUnregisteredExternalDependency),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithUnregisteredExternalDependency), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BCryptPasswordHasher),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IPasswordHasher), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SCryptPasswordHasher),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IPasswordHasher), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Rfc2898PasswordHasher),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IPasswordHasher), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier1),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier1), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier2), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier3),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier3), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier4),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier4), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SomeDep),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDep), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "@ExportMetadataDefaultKey", "---" },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RequiresManyOfType),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RequiresManyOfType), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BlahDep),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDep), "blah", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "@ExportMetadataDefaultKey", "dep" },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.HuhDep),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDep), "huh", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "@ExportMetadataDefaultKey", "dep" },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RequiresManyOfName),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RequiresManyOfName), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RequiresManyOfMeta),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RequiresManyOfMeta), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooHey),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooHey), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IFooService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "@ExportMetadataDefaultKey", DryIoc.MefAttributedModel.UnitTests.CUT.FooMetadata.Hey },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooBlah),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooBlah), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IFooService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "@ExportMetadataDefaultKey", DryIoc.MefAttributedModel.UnitTests.CUT.FooMetadata.Blah },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooConsumerNotFound),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooConsumerNotFound), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForExport),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IForExport), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForExportBaseImpl),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForExportBase), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported), "a", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported), "c", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IMultiExported), "c", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported), "b", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IMultiExported), "i", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IMultiExported), "j", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ILogTableManager),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ILogTableManager), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ILogTableManager), "LogTableManagerFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LogTableManager),
            MemberName = "Create",
            MethodParameterTypeFullNamesOrNames = new String[] {"System.String"}
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LogTableManagerConsumer1),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LogTableManagerConsumer1), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LogTableManagerConsumer2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LogTableManagerConsumer2), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Constants),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Constants), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(System.String),
        Exports = new[] {
            new ExportInfo(typeof(System.String), "ExportedSetting", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Constants),
            MemberName = "ExportedValue",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Constants), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Provider),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Provider), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Abc),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Abc), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Provider),
            MemberName = "ExportedValue",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Provider), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingImportHelper),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingImportHelper), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingProvider1),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingProvider1), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(System.String),
        Exports = new[] {
            new ExportInfo(typeof(System.String), "ExportedSetting", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingProvider1),
            MemberName = "ExportedValue",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingProvider1), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingProvider2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingProvider2), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(System.String),
        Exports = new[] {
            new ExportInfo(typeof(System.String), "ExportedSetting", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingProvider2),
            MemberName = "ExportedValue",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingProvider2), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingProvider3),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingProvider3), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(System.String),
        Exports = new[] {
            new ExportInfo(typeof(System.String), "ExportedSetting", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingProvider3),
            MemberName = "ExportedValue",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingProvider3), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportEarlyProtocolVersions),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportEarlyProtocolVersions), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IVersionedProtocol),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IVersionedProtocol), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportEarlyProtocolVersions),
            MemberName = "V1",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportEarlyProtocolVersions), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IVersionedProtocol),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IVersionedProtocol), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportEarlyProtocolVersions),
            MemberName = "V2",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportEarlyProtocolVersions), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IVersionedProtocol),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IVersionedProtocol), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportEarlyProtocolVersions),
            MemberName = "V3",
            InstanceFactory = new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportEarlyProtocolVersions), "@InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed)
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ModernProtocolImplementation),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IVersionedProtocol), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportAllProtocolVersions),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportAllProtocolVersions), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UntypedService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UntypedService), "ArbitraryKey", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportUntypedService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportUntypedService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportManyUntypedServices),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportManyUntypedServices), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MyScopedService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDisposableScopedService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MySingletonService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDisposableSingletonService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Singleton },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithTwoConstructors),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithTwoConstructors), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonSharedDependency),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonSharedDependency), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SharedDependency),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SharedDependency), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Singleton },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonSharedService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonSharedService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UsesExportFactoryOfNonSharedService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UsesExportFactoryOfNonSharedService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SharedService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SharedService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Singleton },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UsesExportFactoryOfSharedService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UsesExportFactoryOfSharedService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UnspecifiedCreationPolicyService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UnspecifiedCreationPolicyService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UsesExportFactoryOfUnspecifiedCreationPolicyService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UsesExportFactoryOfUnspecifiedCreationPolicyService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyNamedService1),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ILazyNamedService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "DryIoc.MefAttributedModel.UnitTests.CUT.LazyMetadataAttribute", new DryIoc.MefAttributedModel.UnitTests.CUT.LazyMetadataAttribute("One") },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.LazyMetadataAttribute.ToCode()", "new DryIoc.MefAttributedModel.UnitTests.CUT.LazyMetadataAttribute(\"One\")" },
            { "Name", "One" },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyNamedService2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ILazyNamedService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "DryIoc.MefAttributedModel.UnitTests.CUT.LazyMetadataAttribute", new DryIoc.MefAttributedModel.UnitTests.CUT.LazyMetadataAttribute("Two") },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.LazyMetadataAttribute.ToCode()", "new DryIoc.MefAttributedModel.UnitTests.CUT.LazyMetadataAttribute(\"Two\")" },
            { "Name", "Two" },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportLazyNamedServices),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportLazyNamedServices), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportsNamedServiceExportFactories),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportsNamedServiceExportFactories), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonExistingServiceOptionalImports),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonExistingServiceOptionalImports), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonExistingServiceRequiredImport),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonExistingServiceRequiredImport), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonExistingServiceRequiredLazyImport),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonExistingServiceRequiredLazyImport), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonExistingServiceRequiredExportFactoryImport),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonExistingServiceRequiredExportFactoryImport), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonExistingServiceRequiredLazyWithMetadataImport),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonExistingServiceRequiredLazyWithMetadataImport), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonExistingServiceRequiredExportFactoryWithMetadataImport),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonExistingServiceRequiredExportFactoryWithMetadataImport), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultipleMetadataAttributes),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultipleMetadataAttributes), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "DryIoc.MefAttributedModel.UnitTests.CUT.LazyMetadataAttribute", new DryIoc.MefAttributedModel.UnitTests.CUT.LazyMetadataAttribute("MultipleMetadata") },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.LazyMetadataAttribute.ToCode()", "new DryIoc.MefAttributedModel.UnitTests.CUT.LazyMetadataAttribute(\"MultipleMetadata\")" },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.ScriptMetadataAttribute", new DryIoc.MefAttributedModel.UnitTests.CUT.ScriptMetadataAttribute((Int64)123) },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.ScriptMetadataAttribute.ToCode()", "new DryIoc.MefAttributedModel.UnitTests.CUT.ScriptMetadataAttribute((Int64)123)" },
            { "Name", "MultipleMetadata" },
            { "ScriptID", 123 },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportStuffWithMultipleMetadataAttributes),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportStuffWithMultipleMetadataAttributes), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.InheritedMetadataAttributes),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.InheritedMetadataAttributes), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "CategoryName", "Category" },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.ScriptWithCategoryMetadataAttribute", new DryIoc.MefAttributedModel.UnitTests.CUT.ScriptWithCategoryMetadataAttribute((Int64)123, "Category") },
            { "DryIoc.MefAttributedModel.UnitTests.CUT.ScriptWithCategoryMetadataAttribute.ToCode()", "new DryIoc.MefAttributedModel.UnitTests.CUT.ScriptWithCategoryMetadataAttribute((Int64)123, \"Category\")" },
            { "DryIocMetadata", "AlsoSupported" },
            { "ScriptID", 123 },
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportUntypedInheritedMetadata),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportUntypedInheritedMetadata), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonSharedWithImportSatisfiedNotification),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NonSharedWithImportSatisfiedNotification), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Transient },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SharedWithImportSatisfiedNotification),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SharedWithImportSatisfiedNotification), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        Reuse = new ReuseInfo { ReuseType = DryIocAttributes.ReuseType.Singleton },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(void),
        Exports = new[] {
            new ExportInfo(typeof(void), "UnitTestExample", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        Metadata = new System.Collections.Generic.Dictionary<string, Object> {
            { "Title", "Sample" },
        },
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MemberExportWithMetadataExample),
            MemberName = "TestMethodExample"
        }
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UsesMemberExportWithMetadataExample),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UsesMemberExportWithMetadataExample), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PrivateConsumer),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDummyServiceConsumer), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.Fooh<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.Fooh<>), "a", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.FoohFactory<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.FoohFactory<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    },

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.Fooh<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.Fooh<>), "b", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
        },
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
        FactoryMethodInfo = new FactoryMethodInfo {
            DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.FoohFactory<>),
            MemberName = "Create",
            MethodParameterTypeFullNamesOrNames = new String[] {"A"}
        }
    },
        };
    }
}