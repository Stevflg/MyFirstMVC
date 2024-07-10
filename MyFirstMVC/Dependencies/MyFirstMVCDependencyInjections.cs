using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MyFirstMVC.Models.Context;
using MyFirstMVC.Models.Context.Entities;

namespace MyFirstMVC.Dependencies
{
    public static class MyFirstMVCDependencyInjections
    {
        public static IServiceCollection AddMyFirstMvcApp(
            this IServiceCollection services
            ,IConfiguration configs)
        {
            AddMyFirstMvcAppDbContext(services,configs);
            return services;
        }




        private static IServiceCollection AddMyFirstMvcAppDbContext(this IServiceCollection services,IConfiguration configs)
        {
            services.AddDbContext<MyFirstMVCAppDbContext>(options => 
                options.UseSqlServer(configs.GetConnectionString("SqlConnection"))
             );

            //*CoreIdentity Implementation

            var builder = services.AddIdentityCore<AppUsers>();
            var identityBuilder = new IdentityBuilder(builder.UserType,builder.Services);
            identityBuilder.AddRoles<IdentityRole>();
            identityBuilder.AddClaimsPrincipalFactory<UserClaimsPrincipalFactory<AppUsers, IdentityRole>>();
            identityBuilder.AddEntityFrameworkStores<MyFirstMVCAppDbContext>();
            identityBuilder.AddSignInManager<SignInManager<AppUsers>>();
            
            services.TryAddSingleton<ISystemClock, SystemClock>();
            services.Configure<IdentityOptions>(opt => {
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                opt.Lockout.MaxFailedAccessAttempts = 3;
                opt.Lockout.AllowedForNewUsers = true;
                opt.Password.RequiredLength = 8;
            });

            return services;
        }
    }
}
