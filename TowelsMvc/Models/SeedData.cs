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
                        Design = "Solid Color",
                        Softness = "Low",
                        Durability = "a year"
                    },

                     new Towel
                     {
                         Material = "Cotton",
                         Size = "XXL",
                         Price = 500.00M,
                         Design = "Striped",
                         Softness = "Very High",
                         Durability = "a year"
                     },

                      new Towel
                      {
                          Material = "Lyocell",
                          Size = "S",
                          Price = 300.00M,
                          Design = "Jacquard",
                          Softness = "Medium",
                          Durability = "Six Months"
                      },

                       new Towel
                       {
                           Material = "Bamboo",
                           Size = "M",
                           Price = 900.00M,
                           Design = "Printed",
                           Softness = "Low",
                           Durability = "a year"
                       },

                        new Towel
                        {
                            Material = "Poleyster",
                            Size = "S",
                            Price = 50.00M,
                            Design = "Waffle",
                            Softness = "Medium",
                            Durability = "Three Months"
                        },

                         new Towel
                         {
                             Material = "Linen",
                             Size = "L",
                             Price = 200.00M,
                             Design = "Hooded",
                             Softness = "Very High",
                             Durability = "a year"
                         },

                          new Towel
                          {
                              Material = "Microfiber",
                              Size = "M",
                              Price = 700.00M,
                              Design = "Microfiber",
                              Softness = "High",
                              Durability = "Two years"
                          },

                           new Towel
                           {
                               Material = "Synthetic",
                               Size = "M",
                               Price = 400.00M,
                               Design = "Striped",
                               Softness = "Medium",
                               Durability = "Three years"
                           },

                            new Towel
                            {
                                Material = "Turkish Cotton",
                                Size = "L",
                                Price = 900.00M,
                                Design = "Turkish",
                                Softness = "Very High",
                                Durability = "Six Months"
                            },

                             new Towel
                             {
                                 Material = "Hemp",
                                 Size = "XXXL",
                                 Price = 800.00M,
                                 Design = "Printed",
                                 Softness = "Low",
                                 Durability = "a month"
                             }


                );
                context.SaveChanges();
            }
        }
    }
}
