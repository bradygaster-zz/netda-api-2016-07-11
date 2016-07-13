using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TrackPack.Rest.Controllers;
using TrackPack.Rest.Models;
using Swashbuckle.SwaggerGen.Generator;
using Swashbuckle.Swagger.Model;
using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;
using TrackPack.Rest.Services;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;

namespace TrackPack.Rest
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            // add the custom data service
            services.AddTransient<IDataService, MockDataService>();

            // Add swagger
            services.AddSwaggerGen(setup =>
            {
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // wire up 500 page
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();

            // use swagger and swagger-ui
            app.UseSwagger();
            app.UseSwaggerUi();
        }
    }
}
