using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerPlatform.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomerPlatform.Data
{
    public class CustomerPlatformContext : IdentityDbContext<CustomerPlatformUser>
    {
        public CustomerPlatformContext(DbContextOptions<CustomerPlatformContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
