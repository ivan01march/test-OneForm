using Autofac;

namespace OneForm.AdminData
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).Where(t => t.Name.EndsWith("Repo")).AsImplementedInterfaces();
        }
    }
}