using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Autofac;

namespace GC.Client.Base
{
    public class AppFormFactory
    {
        private static IContainer container;
        private static ContainerBuilder builder = new ContainerBuilder();


        public static void RegisterAppForm(Assembly assembly)
        {
            Type baseType = typeof(IAppForm);
            var types = assembly.GetTypes().Where(t => baseType.IsAssignableFrom(t));
            foreach (var item in types)
            {
                builder.RegisterType(item).Named<IAppForm>(item.FullName).InstancePerDependency();
            }
        }

        public static void Builder()
        {
            container = builder.Build();
        }

        public static IAppForm GetAppForm(string className)
        {

            var form = container.ResolveNamed<IAppForm>(className);
            return form;
        }
    }
}
