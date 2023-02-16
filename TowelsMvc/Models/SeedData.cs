using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TowelsMvc.Data;
using System;
using System.Linq;

namespace TowelsMvc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Towel.Any())
                {
                    return;   // DB has been seeded
                }

                context.Towel.AddRange(
                    new Towel
                    {
                        Material = "Nylon",
                        Size = "M",
                        Price = 100.00M,
                        Design = "Nice",
                        Softness = "Very",
                        Durability = "a year"
                    }

                    
                );
                context.SaveChanges();
            }
        }
    }
}