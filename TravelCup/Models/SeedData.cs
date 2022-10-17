using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TravelCup.Data;
using System;
using System.Linq;

namespace TravelCup.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcTravelCupContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcTravelCupContext>>()))
            {
                // Look for any movies.
                if (context.TravelCupClass.Any())
                {
                    return;   // DB has been seeded
                }

                context.TravelCupClass.AddRange(
                    new TravelCupClass
                    {
                        CupsTitle = "WorldCup",
                        ManufactureDate = DateTime.Parse("2000-26-12"),
                        Shape = "Circle",
                        Colour = "Red",
                        Size = "Small",
                        Price = 1200.10M,
                        Rating = 1.5M
                    },

                   new TravelCupClass
                   {
                       CupsTitle = "WorldCup",
                       ManufactureDate = DateTime.Parse("2000-26-12"),
                       Shape = "Circle",
                       Colour = "Red",
                       Size = "Small",
                       Price = 1200.10M,
                       Rating = 1.2M
                   },

                   new TravelCupClass
                   {
                       CupsTitle = "WorldCup",
                       ManufactureDate = DateTime.Parse("2000-26-12"),
                       Shape = "Circle",
                       Colour = "Red",
                       Size = "Small",
                       Price = 1200.10M,
                       Rating = 1.9M
                   },

                    new TravelCupClass
                    {
                        CupsTitle = "WorldCup",
                        ManufactureDate = DateTime.Parse("2000-26-12"),
                        Shape = "Circle",
                        Colour = "Red",
                        Size = "Small",
                        Price = 1200.10M,
                        Rating = 2.9M
                    },
                     new TravelCupClass
                     {
                         CupsTitle = "WorldCup",
                         ManufactureDate = DateTime.Parse("2000-26-12"),
                         Shape = "Circle",
                         Colour = "Red",
                         Size = "Small",
                         Price = 1200.10M,
                         Rating = 2.6M
                     },
                      new TravelCupClass
                      {
                          CupsTitle = "WorldCup",
                          ManufactureDate = DateTime.Parse("2000-26-12"),
                          Shape = "Circle",
                          Colour = "Red",
                          Size = "Small",
                          Price = 1200.10M,
                          Rating = 6.6M
                      },
                       new TravelCupClass
                       {
                           CupsTitle = "WorldCup",
                           ManufactureDate = DateTime.Parse("2000-26-12"),
                           Shape = "Circle",
                           Colour = "Red",
                           Size = "Small",
                           Price = 1200.10M,
                           Rating = 4.2M
                       },
                        new TravelCupClass
                        {
                            CupsTitle = "WorldCup",
                            ManufactureDate = DateTime.Parse("2000-26-12"),
                            Shape = "Circle",
                            Colour = "Red",
                            Size = "Small",
                            Price = 1200.10M,
                            Rating = 9.2M
                        },
                         new TravelCupClass
                         {
                             CupsTitle = "WorldCup",
                             ManufactureDate = DateTime.Parse("2000-26-12"),
                             Shape = "Circle",
                             Colour = "Red",
                             Size = "Small",
                             Price = 1200.10M,
                             Rating = 8.2M
                         },
                          new TravelCupClass
                          {
                              CupsTitle = "WorldCup",
                              ManufactureDate = DateTime.Parse("2000-26-12"),
                              Shape = "Circle",
                              Colour = "Red",
                              Size = "Small",
                              Price = 1200.10M,
                              Rating = 6.8M
                          }
                );
                context.SaveChanges();
            }
        }
    }
}
