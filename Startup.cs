
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PRO_001.Models;
using PRO_001.Models.POSITIONSDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using System;

namespace PRO_001
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

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;

            });
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            { 
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddControllersWithViews();
            services.AddMvc();
            //var conexion = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<erp_MYCADBContext>(options =>
             options.UseSqlServer(Configuration["ConnectionString:erp_MYCADBConnection"]));
            services.AddDbContext<gps_POSITIONSDBContext>(options =>
           options.UseSqlServer(Configuration["ConnectionString:gps_PositionsDBConecction"]));

            //    services.AddIdentity<erp_MYCADBContext, IdentityRole<Guid>>(options =>
            //    {
            //        //Passwork configuration
            //        options.Password.RequireDigit = false;
            //        options.Password.RequireLowercase = false;
            //        options.Password.RequireNonAlphanumeric = false;
            //        options.Password.RequireUppercase = false;
            //        options.Password.RequiredLength = 4;
            //        options.Password.RequiredUniqueChars = 0;

            //        //Lock configuration
            //        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            //        options.Lockout.MaxFailedAccessAttempts = 5;
            //        options.Lockout.AllowedForNewUsers = true;

            //        //User configuration
            //        options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            //        options.User.RequireUniqueEmail = false;
            //    });
            //}
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
