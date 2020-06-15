using Autofac;
using GC.Client.Base;

namespace GC.Client.RBAC
{
    public class ClientModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ServiceProviderManager.AddTransient(ThisAssembly);
        }
    }
}
