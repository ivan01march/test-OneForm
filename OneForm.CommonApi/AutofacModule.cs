using Autofac;

namespace OneForm.CommonApi
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<CommonLogic.AutofacModule>();
        }
    }
}