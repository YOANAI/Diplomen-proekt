using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebFastFoodRestaurantApp.Domain;
using WebFastFoodRestourant.Data;

[assembly: HostingStartup(typeof(WebFastFoodRestourant.Areas.Identity.IdentityHostingStartup))]
namespace WebFastFoodRestourant.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}