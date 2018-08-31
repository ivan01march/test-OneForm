using Autofac;

namespace OneForm.AdminApi
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<AdminLogic.AutofacModule>();
        }
    }
}