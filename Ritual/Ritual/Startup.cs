using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Ritual.Domain;
using Ritual.Domain.Repositories.Abstract;
using Ritual.Domain.Repositories.EntityFramework;
using Ritual.Services;

namespace Ritual
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            //?????????? ?????? ?? appsetting.json
            Configuration.Bind("Project", new config());

            //?????????? ?????? ?????????? ?????????? ? ???????? ????????
            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<IWreathRepository, EFWreathRepository>();
            services.AddTransient<ICrossRepository, EFCrossRepository>();
            services.AddTransient<IDifferentRepositor, EFDifferentRepository>();
            services.AddTransient<IMonumentRepository, EFMonumentRepository>();
            services.AddTransient<IBasketRepositor, EFBasketRepository>();
            services.AddTransient<IInitMonRepositor, EFInitMonRepository>();
            services.AddTransient<IMessegeRepositor, EFMessegeRepository>();

            services.AddTransient<DataManager>();

            //?????????? ???????? ??
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(config.ConnectionString));

            //??????????? identity ???????
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //??????????? authentication cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "myCompanyAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
                
            });

            //??????????? ???????? ??????????? ??? Admin area
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });

            //????????? ??????? ??? ???????????? ? ????????????? (MVC)
            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
            })
                //?????????? ????????????? ? asp.net core 3.0
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
         
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseStaticFiles();

            app.UseRouting();

            //?????????? ?????????????? ? ???????????
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            //????????????? ?????? ??? ???????? (?????????)
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
