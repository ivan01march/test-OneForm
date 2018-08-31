using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OneForm.CommonApi
{
    public class Startup : SharedApi.Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env) : base(configuration, env)
        {
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            return base.ConfigureServices<AutofacModule>(services, null, ServiceLifetime.Scoped);
        }

        public new void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            base.Configure(app, env, loggerFactory);
        }
    }
}