/* ------------------------------------------------------------------------- *
thZero.NetCore.Library.Factories.DryIoc
Copyright (C) 2016-2021 thZero.com

<development [at] thzero [dot] com>

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

	http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
 * ------------------------------------------------------------------------- */

using DryIoc;
using System;

namespace thZero
{
    public class FactoryDryIoc : Factory
    {
        #region Public Methods
        public override void Add(Type type, Type typeInstance, params FactoryConstructorArgument[] parameters)
        {
            Add(type, typeInstance, null, parameters);
        }
        public override void Add(Type type, Type typeInstance, string named, params FactoryConstructorArgument[] parameters)
        {
            if (string.IsNullOrEmpty(named))
                InstanceKernel.Register(type, typeInstance);
            else
                InstanceKernel.Register(type, typeInstance, serviceKey: named);

            if ((parameters != null) && (parameters.Length > 0))
            {
                //	foreach (FactoryConstructorArgument parameter in parameters)
                //		binding.WithConstructorArgument(parameter.Key, parameter.Value);
                throw new NotImplementedException();
            }
        }

        public override void Add<TProviderType>(Type typeInstance, params FactoryConstructorArgument[] parameters)
        {
            Add<TProviderType>(typeInstance, null, parameters);
        }
        public override void Add<TProviderType>(Type typeInstance, string named, params FactoryConstructorArgument[] parameters)
        {
            if (string.IsNullOrEmpty(named))
                InstanceKernel.Register(typeof(TProviderType), typeInstance);
            else
                InstanceKernel.Register(typeof(TProviderType), typeInstance, serviceKey: named);

            //Ninject.Syntax.IBindingWithSyntax<TProviderType> binding = null;
            //if (!string.IsNullOrEmpty(named))
            //	binding = InstanceKernel.Bind<TProviderType>().To(typeInstance).Named(named);
            //else
            //	binding = InstanceKernel.Rebind<TProviderType>().To(typeInstance);

            if ((parameters != null) && (parameters.Length > 0))
            {
                //	foreach (FactoryConstructorArgument parameter in parameters)
                //		binding.WithConstructorArgument(parameter.Key, parameter.Value);
                throw new NotImplementedException();
            }
        }

        public override void Add<TProviderType, TInstanceType>(params FactoryConstructorArgument[] parameters)
        {
            Add<TProviderType, TInstanceType>(null, parameters);
        }
        public override void Add<TProviderType, TInstanceType>(string named, params FactoryConstructorArgument[] parameters)
        {
            if (string.IsNullOrEmpty(named))
                InstanceKernel.Register<TProviderType, TInstanceType>();
            else
                InstanceKernel.Register<TProviderType, TInstanceType>(serviceKey: named);

            //Ninject.Syntax.IBindingWithSyntax<TInstanceType> binding = null;
            //if (!string.IsNullOrEmpty(named))
            //	binding = InstanceKernel.Bind<TProviderType>().To<TInstanceType>().Named(named).ReplaceExisting<TInstanceType>();
            //else
            //	binding = InstanceKernel.Rebind<TProviderType>().To<TInstanceType>();

            if ((parameters != null) && (parameters.Length > 0))
            {
                //	foreach (FactoryConstructorArgument parameter in parameters)
                //		binding.WithConstructorArgument(parameter.Key, parameter.Value);
                throw new NotImplementedException();
            }
        }

        public override void AddContext<TProviderType, TInstanceType>(params FactoryConstructorArgument[] parameters)
        {
            AddContext<TProviderType, TInstanceType>(null, parameters);
        }
        public override void AddContext<TProviderType, TInstanceType>(string named, params FactoryConstructorArgument[] parameters)
        {
            if (string.IsNullOrEmpty(named))
                InstanceKernel.Register<TProviderType>();
            else
                InstanceKernel.Register<TProviderType>(serviceKey: named);

            //Ninject.Syntax.IBindingWithSyntax<TInstanceType> binding = null;
            //if (!string.IsNullOrEmpty(named))
            //	binding = InstanceKernel.Bind<TProviderType>().To<TInstanceType>().InRequestScope().Named(named).ReplaceExisting<TInstanceType>();
            //else
            //	binding = InstanceKernel.Rebind<TProviderType>().To<TInstanceType>().InRequestScope();

            if ((parameters != null) && (parameters.Length > 0))
            {
                //	foreach (FactoryConstructorArgument parameter in parameters)
                //		binding.WithConstructorArgument(parameter.Key, parameter.Value);
                throw new NotImplementedException();
            }
        }

        public override void AddSingleton<TProviderType>(string type, params FactoryConstructorArgument[] parameters)
        {
            AddSingleton<TProviderType>(type, null, parameters);
        }
        public override void AddSingleton<TProviderType>(string type, string named, params FactoryConstructorArgument[] parameters)
        {
            Enforce.AgainstNullOrEmpty(() => type);

            TProviderType obj = (TProviderType)Activator.CreateInstance(Type.GetType(type));
            if (string.IsNullOrEmpty(named))
                InstanceKernel.UseInstance<TProviderType>(obj);
            else
                InstanceKernel.UseInstance<TProviderType>(obj, serviceKey: named);

            //string[] values = type.Split(',');
            //TProviderType constantValue = Utilities.Activator.CreateInstance<TProviderType>(values[1], values[0]);

            //Ninject.Syntax.IBindingWithSyntax<TProviderType> binding = null;
            //if (!string.IsNullOrEmpty(named))
            //	binding = InstanceKernel.Bind<TProviderType>().ToConstant<TProviderType>(constantValue).Named(named).ReplaceExisting<TProviderType>();
            //else
            //	binding = InstanceKernel.Rebind<TProviderType>().ToConstant<TProviderType>(constantValue);

            if ((parameters != null) && (parameters.Length > 0))
            {
                //	foreach (FactoryConstructorArgument parameter in parameters)
                //		binding.WithConstructorArgument(parameter.Key, parameter.Value);
                throw new NotImplementedException();
            }
        }

        public override void AddSingleton(Type providerType, object provider, params FactoryConstructorArgument[] parameters)
        {
            AddSingleton(providerType, provider, null, parameters);
        }
        public override void AddSingleton(Type providerType, object provider, string named, params FactoryConstructorArgument[] parameters)
        {
            throw new InvalidOperationException();
        }

        public override void AddSingleton(Type providerType, Type typeInstance, params FactoryConstructorArgument[] parameters)
        {
            AddSingleton(providerType, typeInstance, null, parameters);
        }
        public override void AddSingleton(Type providerType, Type typeInstance, string named, params FactoryConstructorArgument[] parameters)
        {
            if (string.IsNullOrEmpty(named))
                InstanceKernel.Register(providerType, typeInstance, Reuse.Singleton);
            else
                InstanceKernel.Register(providerType, typeInstance, Reuse.Singleton, serviceKey: named);

            //Ninject.Syntax.IBindingWithSyntax<object> binding = null;
            //if (!string.IsNullOrEmpty(named))
            //	binding = InstanceKernel.Bind(providerType).To(typeInstance).InSingletonScope().Named(named);
            //else
            //	binding = InstanceKernel.Rebind(providerType).To(typeInstance).InSingletonScope();

            if ((parameters != null) && (parameters.Length > 0))
            {
                //	foreach (FactoryConstructorArgument parameter in parameters)
                //		binding.WithConstructorArgument(parameter.Key, parameter.Value);
                throw new NotImplementedException();
            }
        }

        public override void AddSingleton<TProviderType>(Type typeInstance, params FactoryConstructorArgument[] parameters)
        {
            AddSingleton<TProviderType>(typeInstance, null, parameters);
        }
        public override void AddSingleton<TProviderType>(Type typeInstance, string named, params FactoryConstructorArgument[] parameters)
        {
            TProviderType obj = (TProviderType)Activator.CreateInstance(typeInstance);
            if (string.IsNullOrEmpty(named))
                InstanceKernel.UseInstance<TProviderType>(obj);
            else
                InstanceKernel.UseInstance<TProviderType>(obj, serviceKey: named);

            //Ninject.Syntax.IBindingWithSyntax<TProviderType> binding = null;
            //if (!string.IsNullOrEmpty(named))
            //	binding = InstanceKernel.Bind<TProviderType>().To(typeInstance).InSingletonScope().Named(named);
            //else
            //	binding = InstanceKernel.Rebind<TProviderType>().To(typeInstance).InSingletonScope();

            if ((parameters != null) && (parameters.Length > 0))
            {
                //	foreach (FactoryConstructorArgument parameter in parameters)
                //		binding.WithConstructorArgument(parameter.Key, parameter.Value);
                throw new NotImplementedException();
            }
        }

        public override void AddSingleton<TProviderType>(TProviderType instanceType, params FactoryConstructorArgument[] parameters)
        {
            AddSingleton<TProviderType>(instanceType, null, parameters);
        }
        public override void AddSingleton<TProviderType>(TProviderType instanceType, string named, params FactoryConstructorArgument[] parameters)
        {
            if (string.IsNullOrEmpty(named))
                InstanceKernel.UseInstance<TProviderType>(instanceType);
            else
                InstanceKernel.UseInstance<TProviderType>(instanceType, serviceKey: named);

            //Ninject.Syntax.IBindingWithSyntax<TProviderType> binding = null;
            //if (!string.IsNullOrEmpty(named))
            //	binding = InstanceKernel.Bind<TProviderType>().ToConstant<TProviderType>(instanceType).Named(named).ReplaceExisting<TProviderType>();
            //else
            //	binding = InstanceKernel.Rebind<TProviderType>().ToConstant<TProviderType>(instanceType);

            if ((parameters != null) && (parameters.Length > 0))
            {
                //	foreach (FactoryConstructorArgument parameter in parameters)
                //		binding.WithConstructorArgument(parameter.Key, parameter.Value);
                throw new NotImplementedException();
            }
        }

        public override void AddSingleton<TProviderType, TInstanceType>(params FactoryConstructorArgument[] parameters)
        {
            AddSingleton<TProviderType, TInstanceType>(null, parameters);
        }
        public override void AddSingleton<TProviderType, TInstanceType>(string named, params FactoryConstructorArgument[] parameters)
        {
            if (string.IsNullOrEmpty(named))
                InstanceKernel.Register<TProviderType, TInstanceType>(reuse: Reuse.Singleton);
            else
                InstanceKernel.Register<TProviderType, TInstanceType>(reuse: Reuse.Singleton, serviceKey: named);

            //Ninject.Syntax.IBindingWithSyntax<TInstanceType> binding = null;
            //if (!string.IsNullOrEmpty(named))
            //	binding = InstanceKernel.Bind<TProviderType>().To<TInstanceType>().InSingletonScope().Named(named).ReplaceExisting<TInstanceType>();
            //else
            //	binding = InstanceKernel.Rebind<TProviderType>().To<TInstanceType>().InSingletonScope();

            if ((parameters != null) && (parameters.Length > 0))
            {
                //	foreach (FactoryConstructorArgument parameter in parameters)
                //		binding.WithConstructorArgument(parameter.Key, parameter.Value);
                throw new NotImplementedException();
            }
        }

        public override TProviderType Retrieve<TProviderType>()
        {
            try
            {
                return InstanceKernel.Resolve<TProviderType>();
                ////var request = InstanceKernel.CreateRequest(typeof(T), null, new Parameter[0], true, true);
                //TProviderType result = default(TProviderType);
                ////if (!string.IsNullOrEmpty(named))
                ////	result = (T)InstanceKernel.Get<T>(named);
                ////else
                ////	result = (T)InstanceKernel.Get<T>();
                //result = (TProviderType)InstanceKernel.Get<TProviderType>();
                //return result;
                ////return (T)InstanceKernel.Resolve(request).SingleOrDefault();
            }
#if DEBUG
            catch (Exception ex)

#else
			catch
#endif
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(ex.Message);
#endif
                return default;
            }
        }
        public override TProviderType Retrieve<TProviderType>(params FactoryConstructorArgument[] args)
        {
            try
            {
                if (args != null)
                    throw new NotImplementedException();

                return InstanceKernel.Resolve<TProviderType>();
                ////var request = InstanceKernel.CreateRequest(typeof(T), null, new Parameter[0], true, true);
                //TProviderType result = default(TProviderType);
                ////if (!string.IsNullOrEmpty(named))
                ////	result = (T)InstanceKernel.Get<T>(named);
                ////else
                ////	result = (T)InstanceKernel.Get<T>();

                //if (args != null)
                //{
                //	List<IParameter> parameters = new List<IParameter>();
                //	foreach (FactoryConstructorArgument arg in args)
                //		parameters.Add(new ConstructorArgument(arg.Key, arg.Value));

                //	result = (TProviderType)InstanceKernel.Get<TProviderType>(parameters.ToArray());
                //}
                //else
                //	result = (TProviderType)InstanceKernel.Get<TProviderType>();

                //return result;
                ////return (T)InstanceKernel.Resolve(request).SingleOrDefault();
            }
#if DEBUG
            catch (Exception ex)

#else
			catch
#endif
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(ex.Message);
#endif
                return default;
            }
        }
        public override TProviderType Retrieve<TProviderType>(string named)
        {
            try
            {
                return InstanceKernel.Resolve<TProviderType>(serviceKey: named);
                ////var request = InstanceKernel.CreateRequest(typeof(T), null, new Parameter[0], true, true);
                //TProviderType result = default(TProviderType);
                ////if (!string.IsNullOrEmpty(named))
                ////	result = (T)InstanceKernel.Get<T>(named);
                ////else
                ////	result = (T)InstanceKernel.Get<T>();
                //result = (TProviderType)InstanceKernel.Get<TProviderType>(named);
                //return result;
                ////return (T)InstanceKernel.Resolve(request).SingleOrDefault();
            }
#if DEBUG
            catch (Exception ex)

#else
			catch
#endif
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(ex.Message);
#endif
                return default;
            }
        }
        public override TProviderType Retrieve<TProviderType>(string named, params FactoryConstructorArgument[] args)
        {
            try
            {
                if (args != null)
                    throw new NotImplementedException();

                return InstanceKernel.Resolve<TProviderType>(serviceKey: named);
                ////var request = InstanceKernel.CreateRequest(typeof(T), null, new Parameter[0], true, true);
                //TProviderType result = default(TProviderType);
                ////if (!string.IsNullOrEmpty(named))
                ////	result = (T)InstanceKernel.Get<T>(named);
                ////else
                ////	result = (T)InstanceKernel.Get<T>();

                //if (args != null)
                //{
                //	List<IParameter> parameters = new List<IParameter>();
                //	foreach (FactoryConstructorArgument arg in args)
                //		parameters.Add(new ConstructorArgument(arg.Key, arg.Value));

                //	result = (TProviderType)InstanceKernel.Get<TProviderType>(named, parameters.ToArray());
                //}
                //else
                //	result = (TProviderType)InstanceKernel.Get<TProviderType>(named);

                //return result;
                ////return (T)InstanceKernel.Resolve(request).SingleOrDefault();
            }
#if DEBUG
            catch (Exception ex)

#else
			catch
#endif
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(ex.Message);
#endif
                return default;
            }
        }

        public override object Retrieve(Type providerType)
        {
            try
            {
                return InstanceKernel.Resolve(providerType);
                ////var request = InstanceKernel.CreateRequest(providerType, null, new Parameter[0], true, true);
                //object result = null;
                ////if (!string.IsNullOrEmpty(named))
                ////	result = InstanceKernel.Get(providerType, named);
                ////else
                ////	result = InstanceKernel.Get(providerType);
                //result = InstanceKernel.Get(providerType);
                //return result;
                ////return InstanceKernel.Resolve(request).SingleOrDefault();
            }
#if DEBUG
            catch (Exception ex)

#else
			catch
#endif
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(ex.Message);
#endif
                return null;
            }
        }
        public override object Retrieve(Type providerType, params FactoryConstructorArgument[] args)
        {
            try
            {
                if (args != null)
                    throw new NotImplementedException();

                return InstanceKernel.Resolve(providerType);
                ////var request = InstanceKernel.CreateRequest(providerType, null, new Parameter[0], true, true);
                //object result = null;
                ////if (!string.IsNullOrEmpty(named))
                ////	result = InstanceKernel.Get(providerType, named);
                ////else
                ////	result = InstanceKernel.Get(providerType);

                //if (args != null)
                //{
                //	List<IParameter> parameters = new List<IParameter>();
                //	foreach (FactoryConstructorArgument arg in args)
                //		parameters.Add(new ConstructorArgument(arg.Key, arg.Value));

                //	result = InstanceKernel.Get(providerType, parameters.ToArray());
                //}
                //else
                //	result = InstanceKernel.Get(providerType);

                //return result;
                ////return (T)InstanceKernel.Resolve(request).SingleOrDefault();
            }
#if DEBUG
            catch (Exception ex)

#else
			catch
#endif
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(ex.Message);
#endif
                return null;
            }
        }
        public override object Retrieve(Type providerType, string named)
        {
            try
            {

                return InstanceKernel.Resolve(providerType, serviceKey: named);
                ////var request = InstanceKernel.CreateRequest(providerType, null, new Parameter[0], true, true);
                //object result = null;
                ////if (!string.IsNullOrEmpty(named))
                ////	result = InstanceKernel.Get(providerType, named);
                ////else
                ////	result = InstanceKernel.Get(providerType);
                //result = InstanceKernel.Get(providerType, named);
                //return result;
                ////return InstanceKernel.Resolve(request).SingleOrDefault();
            }
#if DEBUG
            catch (Exception ex)

#else
			catch
#endif
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(ex.Message);
#endif
                return null;
            }
        }
        public override object Retrieve(Type providerType, string named, params FactoryConstructorArgument[] args)
        {
            try
            {
                if (args != null)
                    throw new NotImplementedException();

                return InstanceKernel.Resolve(providerType, serviceKey: named);
                ////var request = InstanceKernel.CreateRequest(providerType, null, new Parameter[0], true, true);
                //object result = null;
                ////if (!string.IsNullOrEmpty(named))
                ////	result = InstanceKernel.Get(providerType, named);
                ////else
                ////	result = InstanceKernel.Get(providerType);

                //if (args != null)
                //{
                //	List<IParameter> parameters = new List<IParameter>();
                //	foreach (FactoryConstructorArgument arg in args)
                //		parameters.Add(new ConstructorArgument(arg.Key, arg.Value));

                //	result = InstanceKernel.Get(providerType, named, parameters.ToArray());
                //}
                //else
                //	result = InstanceKernel.Get(providerType, named);

                //return result;
                ////return (T)InstanceKernel.Resolve(request).SingleOrDefault();
            }
#if DEBUG
            catch (Exception ex)

#else
			catch
#endif
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(ex.Message);
#endif
                return null;
            }
        }

        public override System.Collections.Generic.IEnumerable<TProviderType> Retrieves<TProviderType>()
        {
            try
            {
                return InstanceKernel.ResolveMany<TProviderType>();
                //var request = InstanceKernel.CreateRequest(typeof(TProviderType), null, new Parameter[0], true, true);
                //var enumeration = InstanceKernel.Resolve(request);
                //System.Collections.Generic.List<TProviderType> list = new System.Collections.Generic.List<TProviderType>();
                //foreach (object o in enumeration)
                //	list.Add((TProviderType)o);
                //return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override System.Collections.Generic.IEnumerable<object> Retrieves(Type providerType)
        {
            try
            {
                return InstanceKernel.ResolveMany(providerType);
                //var request = InstanceKernel.CreateRequest(providerType, null, new Parameter[0], true, true);
                //return InstanceKernel.Resolve(request).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region Protected Methods
        protected override void InitializeInstance()
        {
        }
        #endregion

        #region Protected Properties
        protected static IContainer InstanceKernel
        {
            get
            {
                lock (LockKernel)
                {
                    if (_instance == null)
                        _instance = new Container();
                }

                return _instance;
            }
        }
        #endregion

        #region Fields
        private static volatile IContainer _instance;
        private static readonly object LockKernel = new();
        #endregion
    }
}