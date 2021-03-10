using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Negociantes.Areas.Identity.Data;
using Negociantes.Data;

[assembly: HostingStartup(typeof(Negociantes.Areas.Identity.IdentityHostingStartup))]
namespace Negociantes.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<NegociantesContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("NegociantesContextConnection")));

                services.AddDefaultIdentity<NegociantesUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<NegociantesContext>();
            });
        }
    }
}