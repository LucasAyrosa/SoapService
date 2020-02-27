using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SoapCore;
using SoapService.Contracts;
using SoapService.Services;

namespace SoapService
{
    public class Startup
    {
        public readonly IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IService, Service>();
            services.AddMvc(opt => opt.EnableEndpointRouting = false);
            services.AddSoapCore();
            services.Configure<IISServerOptions>(options => options.AutomaticAuthentication = false);
            services.Configure<IISOptions>(options => options.ForwardClientCertificate = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSoapEndpoint<IService>("/SoapService.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);
            app.UseMvc();
        }
    }
}
