using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcWithAuth.Areas.Identity.Data;

[assembly: HostingStartup(typeof(MvcWithAuth.Areas.Identity.IdentityHostingStartup))]
namespace MvcWithAuth.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MvcWithAuthIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MvcWithAuthIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MvcWithAuthIdentityDbContext>();
            });
        }
    }
}