using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyFlatAPI.Data;
using MyFlatAPI.Data.Repositories.Abstract;
using MyFlatAPI.Data.Repositories.EF;

namespace MyFlatAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //подключаем Config из appsettings.json для получения connectionString
            Configuration.Bind("MyFlatAPI", new Config());

            //подключаем сервисы
            
            services.AddTransient<IAccountRepositoryAPI, EFAccountRepositoryAPI>();
            services.AddTransient<IRenderingRepositoryAPI, EFRenderingRepositoryAPI>();
            services.AddTransient<IPageEditorRepositoryAPI, EFPageEditorRepositoryAPI>();
            services.AddTransient<DataManager>();

            //подключаем контекст БД
            services.AddDbContext<MyFlatAPIDBContext>(x => x.UseSqlServer(Config.ConnectionString));

            //настраиваем Identity систему
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            })
            .AddEntityFrameworkStores<MyFlatAPIDBContext>()
            .AddDefaultTokenProviders();

            services.AddControllers();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddHttpContextAccessor();
            services.AddRouting(options =>
            {
                options.ConstraintMap.Add("OrderModel", typeof(ProvaRouteConstraint));
                options.ConstraintMap.Add("PeriodModel", typeof(ProvaRouteConstraint));
                options.ConstraintMap.Add("LoginModel", typeof(ProvaRouteConstraint));
                options.ConstraintMap.Add("RegisterModel", typeof(ProvaRouteConstraint));
                options.ConstraintMap.Add("ChangeStatusModel", typeof(ProvaRouteConstraint));
                options.ConstraintMap.Add("TopMenuLinkNameModel", typeof(ProvaRouteConstraint));
                options.ConstraintMap.Add("RandomPhraseModel", typeof(ProvaRouteConstraint));
                options.ConstraintMap.Add("HomePagePlaceholderModel", typeof(ProvaRouteConstraint));
                options.ConstraintMap.Add("ProjectModel", typeof(ProvaRouteConstraint));
                options.ConstraintMap.Add("ServiceModel", typeof(ProvaRouteConstraint));
                options.ConstraintMap.Add("PostModel", typeof(ProvaRouteConstraint));
            });
        }
        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name:"default",
                                             pattern:"{controller=RolesAPI}/{action=GetRoles}/{id?}/{param?}");
                //endpoints.MapControllerRoute(name: "default",
                //    pattern: "{controller=RolesAPI}/{action=GetRoles}/{id?}");
            });
        }

        internal class ProvaRouteConstraint : IRouteConstraint
        {
            public bool Match(HttpContext? httpContext, IRouter? route, string routeKey,
                              RouteValueDictionary values, RouteDirection routeDirection)
            {
                return false;
            }
        }
    }
}
