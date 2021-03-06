﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JFA.Yearbook.Web.Users;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Piranha;
using Piranha.AspNetCore.Identity.SQLite;
using Piranha.ImageSharp;
using Piranha.Local;

namespace JFA.Yearbook.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(config => 
            {
                config.ModelBinderProviders.Insert(0, new Piranha.Manager.Binders.AbstractModelBinderProvider());
            });
            services.AddPiranhaApplication();
            services.AddPiranhaFileStorage();
            services.AddPiranhaImageSharp();
            services.AddPiranhaEF(options => options.UseSqlite("Filename=./JFA.Yearbook.Web.db"));
            services.AddPiranhaIdentityWithSeed<IdentitySQLiteDb, Batch97Identity>(options => options.UseSqlite("Filename=./JFA.Yearbook.Web.db"));
            services.AddPiranhaManager();
            services.AddPiranhaMemCache();

            return services.BuildServiceProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider services, IApi api)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Initialize Piranha
            App.Init();

            // Configure cache level
            App.CacheLevel = Piranha.Cache.CacheLevel.Basic;

            // Build content types
            var pageTypeBuilder = new Piranha.AttributeBuilder.PageTypeBuilder(api)
                .AddType(typeof(Models.StandardPage))
                .AddType(typeof(Sections.Models.SectionPage));
            pageTypeBuilder.Build()
                .DeleteOrphans();
            var postTypeBuilder = new Piranha.AttributeBuilder.PostTypeBuilder(api);
            postTypeBuilder.Build()
                .DeleteOrphans();

            // Register middleware
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UsePiranha();
            app.UsePiranhaManager();
            app.UseMvc(routes => 
            {
                routes.MapRoute(name: "areaRoute",
                    template: "{area:exists}/{controller}/{action}/{id?}",
                    defaults: new { controller = "Sections", action = "Index" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=sections}/{action=index}/{id?}");
            });
        }
    }
}
