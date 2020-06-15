using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GC.Client.Base
{
    public class ServiceProviderManager
    {
        private static readonly ConcurrentDictionary<string, Type> classNameTypeMap = new ConcurrentDictionary<string, Type>();

        private static IServiceCollection _services;
        private static IServiceProvider _serviceProvider;

        public static void Initialization(IServiceCollection services)
        {
            _services = services;
        }


        public static void Builder() 
        {
            _serviceProvider = _services.BuildServiceProvider();
        }

        public static void AddSingleton(Assembly assembly)
        {
            Type baseType = typeof(Form);
            var types = assembly.GetTypes().Where(t => baseType.IsAssignableFrom(t));
            foreach (var item in types)
            {
                AddSingleton(item);
            }
        }


        public static void AddTransient(Assembly assembly)
        {
            Type baseType = typeof(Form);
            var types = assembly.GetTypes().Where(t => baseType.IsAssignableFrom(t));
            foreach (var item in types)
            {
                AddTransient(item);
            }
        }

        public static void AddSingleton<TService>() where TService : class
        {
            Type type = typeof(TService);
            classNameTypeMap.GetOrAdd(type.FullName, type);
            _services.AddSingleton<TService>();
        }

        public static void AddTransient<TService>() where TService : class
        {
            Type type = typeof(TService);
            classNameTypeMap.GetOrAdd(type.FullName, type);
            _services.AddTransient<TService>();
        }


        public static void AddSingleton(Type type)
        {
            classNameTypeMap.GetOrAdd(type.FullName, type);
            _services.AddSingleton(type);
        }

        public static void AddTransient(Type type)
        {
            classNameTypeMap.GetOrAdd(type.FullName, type);
            _services.AddTransient(type);
        }


        public static Form GetForm(string className)
        {
            if (!classNameTypeMap.TryGetValue(className, out Type type))
            {
                throw new Exception("窗体未定义！！！");
            }
            var form = (Form)_serviceProvider.GetRequiredService(type);
            return form;
        }
    }
}
