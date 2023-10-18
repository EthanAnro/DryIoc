// <auto-generated/>
/*
The MIT License (MIT)

Copyright (c) 2016-2023 Maksim Volkau

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
/*
======================================================================================================
The code below is auto-generated at compile-time and changes here will be lost on the next generation.
======================================================================================================

WARNINGS: Some dependencies are missing. Register them at runtime or add to the compile-time registrations.

- `RuntimeDependencyC` in resolution root MyService: IService FactoryID=1
  from container without scope
 with Rules with {ThrowIfRuntimeStateRequired, UsedForExpressionGeneration, GenerateResolutionCallForMissingDependency} and without {ImplicitCheckForReuseMatchingScope, EagerCachingSingletonForFasterAccess, UseInterpretationForTheFirstResolution}
--------------------------------------------------------------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Threading;
using DryIoc.ImTools;

// Provided by `NamespaceUsings`:
using Example;

namespace DryIoc
{
    ///<summary>The container provides access to the object graph generated using the DryIoc own tools at compile-time</summary>
    public sealed class CompileTimeContainer : ICompileTimeContainer
    {
        ///<summary>The instance if generated compile-time container.</summary>
        public static readonly CompileTimeContainer Instance = new CompileTimeContainer();

        // todo: @wip tbd
        /// <inheritdoc/>
        public bool IsRegistered(Type serviceType) => false;
        /// <inheritdoc/>
        public bool IsRegistered(Type serviceType, object serviceKey) => false;

        /// <inheritdoc/>
        public bool TryResolve(out object service, IResolverContext r, Type serviceType)
        {

            if (serviceType == typeof(IService))
            {
                service = Get_IService_0(r);
                return true;
            }
            else
            if (serviceType == typeof(BaseAConsumer))
            {
                service = Get_BaseAConsumer_1(r);
                return true;
            }
            service = null;
            return false;
        }

        /// <inheritdoc/>
        public bool TryResolve(out object service, IResolverContext r,
            Type serviceType, object serviceKey, Type requiredServiceType, Request preRequestParent, object[] args)
        {
            if (serviceType == typeof(DependencyB<string>))
            {
                if (serviceKey == null &&
                    requiredServiceType == null &&
                    Equals(preRequestParent, Request.Empty.Push(
                        typeof(IService),
                        1,
                        typeof(MyService),
                        Reuse.Transient,
                        RequestFlags.IsResolutionCall|RequestFlags.DoNotPoolRequest)))
                {
                    service = GetDependency_DependencyB_1(r);
                    return true;
                }
            }
            service = null;
            return false;
        }

        /// <inheritdoc/>
        public IEnumerable<ResolveManyResult> ResolveMany(IResolverContext _, Type serviceType)
        {
            if (serviceType == typeof(IService))
                yield return ResolveManyResult.Of(r => Get_IService_0(r));
            if (serviceType == typeof(BaseAConsumer))
                yield return ResolveManyResult.Of(r => Get_BaseAConsumer_1(r));
        }

        internal static IService Get_IService_0(IResolverContext r) =>
            new MyService(
                new DependencyA(),
                ((DependencyB<string>)r.Resolve(
                    typeof(DependencyB<string>),
                    default(object),
                    IfUnresolved.Throw,
                    default(System.Type),
                    Request.Empty.Push(
                        typeof(IService),
                        1,
                        typeof(MyService),
                        Reuse.Transient,
                        RequestFlags.IsResolutionCall|RequestFlags.StopRecursiveDependencyCheck|RequestFlags.DoNotPoolRequest),
                    default(object[]))),
                ((RuntimeDependencyC)r.Resolve(
                    typeof(RuntimeDependencyC),
                    default(object),
                    IfUnresolved.Throw,
                    default(System.Type),
                    Request.Empty.Push(
                        typeof(IService),
                        1,
                        typeof(MyService),
                        Reuse.Transient,
                        RequestFlags.IsResolutionCall|RequestFlags.DoNotPoolRequest),
                    default(object[]))));

        internal static BaseAConsumer Get_BaseAConsumer_1(IResolverContext r) =>
            new BaseAConsumer(WrappersSupport.WrapInDictionary<object, BaseA>(new System.Collections.Generic.KeyValuePair<object, BaseA>[] {
                new System.Collections.Generic.KeyValuePair<object, BaseA>(
                    (object)"keyed",
                    new KeyedA()),
                new System.Collections.Generic.KeyValuePair<object, BaseA>(
                    DefaultKey.Of(0),
                    new NonKeyedA())}));

        internal static DependencyB<string> GetDependency_DependencyB_1(IResolverContext r) =>
            new DependencyB<string>(new DependencyA());

    }
}
