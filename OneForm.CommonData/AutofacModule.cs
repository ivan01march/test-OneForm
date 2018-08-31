using Autofac;

namespace OneForm.CommonData
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).Where(t => t.Name.EndsWith("Repo")).AsImplementedInterfaces();
        }
    }
}