using System;
using Autofac;
using Serilog;

namespace OneForm.CommonLogic
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<CommonData.AutofacModule>();
            builder.RegisterAssemblyTypes(ThisAssembly).Where(t => t.Name.EndsWith("Logic")).AsImplementedInterfaces();
        }
    }
}