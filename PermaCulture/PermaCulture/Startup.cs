using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PermaCulture.Api.Extensions;
using PermaCulture.Repository;
using Swashbuckle.AspNetCore.Swagger;

namespace PermaCulture
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(
                 c => { c.SwaggerDoc("v1", new Info { Title = "Core API", Description = "Swagger Core API" }); }

            );
            //var conn = Configuration.GetConnectionString("DefaultConnection");
            //services.AddDbContext<AppContext>(options => options.UseSqlServer(conn));

            services.AddDbContext<PermaCultureContext>(options => options.UseSqlServer("Server=SAFI\\SQLEXPRESS;Database=PermaCulture;Trusted_Connection=True;"));
            //services.AddDbContext<PermaCultureContext>();
            //services.AddScoped<PermaCultureContext>(sp => sp.GetService<PermaCultureContext>());
            //container = services.BuildServiceProvider();


            services.ConfigureDependencies();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PermaCulture API.");
            }


                );
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }

        //public void ConfigureServices(IServiceCollection services)
        //{

        //    services.ConfigureDependencies();
        //}
    }
}
