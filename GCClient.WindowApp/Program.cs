using Autofac;
using Autofac.Configuration;
using FHEC.GC.Contract;
using GC.Client.Base;
using GC.Client.RBAC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCClient.WindowApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //创建服务容器对象
            var services = new ServiceCollection();
            
            //添加服务注册
            ConfigureServices(services);

            
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<Login>();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var userCreateForm = serviceProvider.GetRequiredService<UserCreateForm>();
                    Application.Run(userCreateForm);
                    //MainForm mainForm = new MainForm(form.vusermenuList, serviceProvider);
                    //Application.Run(mainForm);
                }

            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            //TODO:注入所有窗体
            services.AddSingleton<Login>();
            services.AddSingleton<UserCreateForm>();
            services.AddSingleton<UserEditForm>();
            services.AddSingleton<UserRoleCreateForm>();
            services.AddSingleton<UserRoleEditForm>();
            services.AddSingleton<RolePowerForm>();
            ServiceProviderManager.Initialization(services);
            InitAutofac();
            ServiceProviderManager.Builder();
            string[] cmd = new string[] { "--Ice.ImplicitContext=Shared" };
            var communicator = Ice.Util.initialize(ref cmd);
            var ic = communicator.getImplicitContext();
            //注册应用服务客户端
            services.AddSingleton(communicator)
                .AddRightsUploadService()
                .AddRightsQueryService();
        }

        private static IContainer InitAutofac()
        {
            ConfigurationBuilder config = new ConfigurationBuilder();
            config.AddJsonFile("GC.Client.json");
            var module = new ConfigurationModule(config.Build());
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule(module);
            IContainer container = builder.Build();
            return container;
        }
    }
}
