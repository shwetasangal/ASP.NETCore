using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.IO;
using TestApp1.Services;

namespace TestApp1
{
    public class Startup
    {
        public Startup()
        {
            var Builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSettings.json");

            Configuration = Builder.Build();
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton(provider => Configuration);
            services.AddSingleton<IMessageService, ConfigurationMessageService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,IMessageService msg)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();

            app.UseMvc(routes =>
                {
                    routes.MapRoute
                    (
                        name: "default",
                        template: "{controller=Home}/{action=Index}/{Id?}"
                    );
                }
                );

            app.Run(async (context) =>
            {
               // throw new Exception("Fake Exception!");
                await context.Response.WriteAsync(msg.GetMessage());
            });
        }
    }
}
