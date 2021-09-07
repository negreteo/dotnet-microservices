using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;

namespace PlatformService.Data
{
  // static = no instances will be created for this class 
  public static class PrepDb
  {
    public static void PrepPopulation(IApplicationBuilder app)
    {
      using (var serviceScope = app.ApplicationServices.CreateScope())
      {
        SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
      }
    }

    private static void SeedData(AppDbContext context)
    {
      if (!context.Platforms.Any())
      {
        Console.WriteLine("--> Seeding data...");

        // Adds a number of objects
        context.Platforms.AddRange(
          new Platform() { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
          new Platform() { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" },
          new Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }
        );

        context.SaveChanges();
      }
      else
      {
        Console.WriteLine("--> We already have data");
      }
    }

  }
}