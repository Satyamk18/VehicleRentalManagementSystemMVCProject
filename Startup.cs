using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VehicleRentalManagementProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Authorization;


namespace VehicleRentalManagementProject
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
            services.AddControllersWithViews();
            services.AddDbContext<ACE42023Context>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            
            services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();  
            services.AddSession();
            services.AddAuthentication()
                    .AddCookie(options=>{
                        options.LoginPath="/Account/Login";
                        options.AccessDeniedPath="/Account/AccessDenied";
                    });
            // using Microsoft.AspNetCore.Authentication.Cookies;
            // services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //     .AddCookie(options =>
            //     {
            //         // using Microsoft.AspNetCore.Http;
            //         options.LoginPath = new PathString("/Account/Login");
            //         options.LogoutPath = new PathString("/Account/Logout");
            //         options.AccessDeniedPath = new PathString("/Account/AccessDenied");
            
            //         options.ReturnUrlParameter = "ReturnUrl";
            
            //         // https://docs.microsoft.com/en-us/aspnet/core/security/authentication/cookie?view=aspnetcore-3.1#react-to-back-end-changes                    
            //         // options.EventsType = typeof(CustomCookieAuthenticationEvents);
            //     });
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
            
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
