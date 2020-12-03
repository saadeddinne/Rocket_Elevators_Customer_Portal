using System;
using CustomerPlatform.Areas.Identity.Data;
using CustomerPlatform.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CustomerPlatform.Areas.Identity.IdentityHostingStartup))]
namespace CustomerPlatform.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CustomerPlatformContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CustomerPlatformContextConnection")));

                services.AddDefaultIdentity<CustomerPlatformUser>(options => {
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.SignIn.RequireConfirmedAccount = false;
                })
                    .AddEntityFrameworkStores<CustomerPlatformContext>();
            });
        }
    }
}