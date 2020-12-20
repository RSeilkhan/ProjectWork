using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lunch.Data;
using Lunch.Interfaces;
using Lunch.Models;
using Lunch.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Lunch
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(mvcOtions =>
            {
                mvcOtions.EnableEndpointRouting = false;
            });

            services.AddTransient<Models.IPasswordValidator<User>,
                CustomPasswordValidator>(serv => new CustomPasswordValidator(6));
            services.AddTransient<Models.IUserValidator<User>, CustomUserValidator>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>(opts => {
                opts.User.RequireUniqueEmail = true;    // ���������� email
                opts.User.AllowedUserNameCharacters = ".@abcdefghijklmnopqrstuvwxyz"; // ���������� �������
                opts.Password.RequiredLength = 5;   // ����������� �����
                opts.Password.RequireNonAlphanumeric = false;   // ��������� �� �� ���������-�������� �������
                opts.Password.RequireLowercase = true; // ��������� �� ������� � ������ ��������
                opts.Password.RequireUppercase = true; // ��������� �� ������� � ������� ��������
                opts.Password.RequireDigit = true; // ��������� �� �����
            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddRazorPages();
            services.AddTransient<IAllKitchens, KitchenRepository>();
            services.AddTransient<IAllLinks, LinkRepository>();
            services.AddTransient<IAllMenus, MenuRepository>();
            services.AddTransient<IAllPlaces, PlaceRepository>();


            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();   
            app.UseAuthorization();

            using (var scope = app.ApplicationServices.CreateScope())
            {
                ApplicationDbContext content = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                DBObjects.Initial(content);

            }

          
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                   name: "kitchenFilter",
                   template: "Places/{action}/{kitchen?}", defaults: new { Controller = "Places", action = "Index" });

            });



        }
    }
}
