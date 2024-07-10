using MyFirstMVC.Data.Enums;
using MyFirstMVC.Models.Context;
using MyFirstMVC.Models.Context.Entities;
using System.Data;

namespace MyFirstMVC.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var servicesScoped = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = servicesScoped.ServiceProvider.GetService<MyFirstMVCAppDbContext>();
                context.Database.EnsureCreated();


                using (var transaction = context.Database.BeginTransaction())
                {
                    if(!context.Clubs.Any())
                    {
                        context.Clubs.AddRange(new List<Club>
                        {
                            new Club{
                                Title = "Running Club 1",
                                Image = "",
                                Description = "Club estatal de atletismo",
                                ClubCategory = ClubCategory.City,
                                Address = new Address
                                {
                                    Street = "123 Main Ct",
                                    City = "Charlotte",
                                    State = "NC"
                                }
                            },
                            new Club{
                                Title = "Running Club 2",
                                Image = "",
                                Description = "Club estatal de atletismo",
                                ClubCategory = ClubCategory.Womens,
                                Address = new Address
                                {
                                    Street = "Colorado",
                                    City = "Colorado",
                                    State = "EEN"
                                }
                            },
                            new Club{
                                Title = "Running Club 3",
                                Image = "",
                                Description = "Club estatal de atletismo",
                                ClubCategory = ClubCategory.Trail,
                                Address = new Address
                                {
                                    Street = "Kansas",
                                    City = "Kansas City",
                                    State = "NA"
                                }
                            }
                        });
                    }
                    if (!context.Races.Any())
                    {
                        context.Races.AddRange(new List<Race>
                        {
                            new Race{
                                Title = "Running Club 1",
                                Image = "",
                                Description = "Club estatal de atletismo",
                                RaceCategory = RaceCategory.Ultra,
                                Address = new Address
                                {
                                    Street = "123 Main Ct",
                                    City = "Charlotte",
                                    State = "NC"
                                }
                            },
                            new Race{
                                Title = "Running Club 2",
                                Image = "",
                                Description = "Club estatal de atletismo",
                                RaceCategory = RaceCategory.Fivek,
                                Address = new Address
                                {
                                    Street = "Colorado",
                                    City = "Colorado",
                                    State = "EEN"
                                }
                            },
                            new Race{
                                Title = "Running Club 3",
                                Image = "",
                                Description = "Club estatal de atletismo",
                                RaceCategory = RaceCategory.Tenk,
                                Address = new Address
                                {
                                    Street = "Kansas",
                                    City = "Kansas City",
                                    State = "NA"
                                }
                            }
                        });
                    }
                    var result = context.SaveChanges();
                    if (result > 0) transaction.Commit();
                    else transaction.Rollback();
                }
            }
        }
    }
}