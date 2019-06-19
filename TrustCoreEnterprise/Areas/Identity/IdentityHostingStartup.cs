using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrustCoreEnterprise.Models;

[assembly: HostingStartup(typeof(TrustCoreEnterprise.Areas.Identity.IdentityHostingStartup))]
namespace TrustCoreEnterprise.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
               /* services.AddDbContext<TrustCoreEnterpriseContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TrustCoreEnterpriseConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<TrustCoreEnterpriseContext>();
                    */
            });
        }
    }
}