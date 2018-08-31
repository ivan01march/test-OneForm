using System;
using System.Reflection;
using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NSwag.AspNetCore;
using OneForm.SharedData;
using Serilog;

namespace OneForm.SharedApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder
                .AddJsonFile("appsettings.shared.json")
                .AddJsonFile($"appsettings.shared.{env.EnvironmentName}.json")
                .AddConfiguration(configuration);
            Configuration = configurationBuilder.Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .CreateLogger();
        }

        public IConfiguration Configuration { get; }

        protected IServiceProvider ConfigureServices<TAutofacModule>(
            IServiceCollection services,
            ContainerBuilder containerBuilder = null,
            ServiceLifetime? dbContextLifeTime = null
        ) where TAutofacModule : IModule, new()
        {
            if (containerBuilder == null) containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<TAutofacModule>();
            return ConfigureServices(services, containerBuilder, dbContextLifeTime);
        }

        protected IServiceProvider ConfigureServices(
            IServiceCollection services,
            ContainerBuilder containerBuilder = null,
            ServiceLifetime? dbContextLifeTime = null
        )
        {
            if (dbContextLifeTime != null)
            {
                var connectionStr = Configuration.GetConnectionString("DefaultConnection");
                services.AddDbContext<OneFormContext>(
                    options => options.UseSqlServer(connectionStr), dbContextLifeTime.Value);
            }

            services.AddCors();
            services.AddMvc();

            if (containerBuilder == null)
                containerBuilder = new ContainerBuilder();
            containerBuilder.Populate(services);
            containerBuilder.RegisterInstance(Configuration);
            var container = containerBuilder.Build();
            return new AutofacServiceProvider(container);
        }

        protected void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            loggerFactory.AddSerilog();
            app.UseCors(b => b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            app.UseSwaggerUi(Assembly.GetCallingAssembly(), settings => { });
            app.UseMvc();
        }
    }
}