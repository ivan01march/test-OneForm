using Autofac;

namespace OneForm.AdminLogic
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<AdminData.AutofacModule>();

            builder.RegisterAssemblyTypes(ThisAssembly).Where(t => t.Name.EndsWith("Logic")).AsImplementedInterfaces();
        }
    }
}