using System.Collections.Generic;
using AutoBarn.WebUI.Data;
using AutoBarn.WebUI.Data.Entities;

namespace AutoBarn.WebUI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AutoBarn.WebUI.Data.AutobarnContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AutoBarn.WebUI.Data.AutobarnContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Contacts.AddOrUpdate(c => c.Id,
                new Contact { Firstname = "Tony" });

            context.Makes.AddOrUpdate(m => m.Id,
                new Make
                {
                    Name = "Audi",
                    Models = new List<Model>
                {
                    new Model { Name = "A3", Services = new List<Service> { new Service { Name = "Oil Service", Price = 99, DealerPrice = 165}, new Service {Name = "Annual Service", Price = 129, DealerPrice = 245}, new Service { Name = "Major Service", Price = 199, DealerPrice = 370} } },
                    new Model { Name = "A4", Services = new List<Service> { new Service { Name = "Oil Service", Price = 99, DealerPrice = 170}, new Service {Name = "Annual Service", Price = 129, DealerPrice = 255}, new Service { Name = "Major Service", Price = 199, DealerPrice = 380} } },
                    new Model { Name = "A5", Services = new List<Service> { new Service { Name = "Oil Service", Price = 99, DealerPrice = 180}, new Service {Name = "Annual Service", Price = 129, DealerPrice = 265}, new Service { Name = "Major Service", Price = 209, DealerPrice = 385} } },
                    new Model { Name = "A6", Services = new List<Service> { new Service { Name = "Oil Service", Price = 99, DealerPrice = 190}, new Service {Name = "Annual Service", Price = 129, DealerPrice = 270}, new Service { Name = "Major Service", Price = 209, DealerPrice = 386} } },
                    new Model { Name = "A8", Services = new List<Service> { new Service { Name = "Oil Service", Price = 114, DealerPrice = 210}, new Service {Name = "Annual Service", Price = 149, DealerPrice = 310}, new Service { Name = "Major Service", Price = 219, DealerPrice = 395 } } },
                }
                });

            context.Makes.AddOrUpdate(m => m.Id,
                new Make
                {
                    Name = "BMW",
                    Models = new List<Model>
                {
                    new Model { Name = "1 Series", Services = new List<Service> { new Service { Name = "Oil Service", Price = 99, DealerPrice = 225}, new Service {Name = "Annual Service", Price = 129, DealerPrice = 295}, new Service { Name = "Major Service", Price = 199, DealerPrice = 460} } },
                    new Model { Name = "2 Series", Services = new List<Service> { new Service { Name = "Oil Service", Price = 99, DealerPrice = 230}, new Service {Name = "Annual Service", Price = 129, DealerPrice = 310}, new Service { Name = "Major Service", Price = 194, DealerPrice = 480} } },
                    new Model { Name = "5 Series", Services = new List<Service> { new Service { Name = "Oil Service", Price = 105, DealerPrice = 240}, new Service {Name = "Annual Service", Price = 135, DealerPrice = 330}, new Service { Name = "Major Service", Price = 205, DealerPrice = 485} } },
                    new Model { Name = "7 Series", Services = new List<Service> { new Service { Name = "Oil Service", Price = 119, DealerPrice = 255}, new Service {Name = "Annual Service", Price = 149, DealerPrice = 375}, new Service { Name = "Major Service", Price = 219, DealerPrice = 495} } },
                }
                });

            context.Makes.AddOrUpdate(m => m.Id,
                new Make
                {
                    Name = "Mercedes-Benz",
                    Models = new List<Model>
                {
                    new Model { Name ="A CLASS" },
                    new Model { Name ="B CLASS" },
                    new Model { Name ="C CLASS" },
                    new Model { Name ="CLK"     },
                    new Model { Name ="E CLASS" },
                    new Model { Name ="M CLASS" },
                    new Model { Name ="Other"   },
                    new Model { Name ="S CLASS" },
                    new Model { Name ="SLK"     },
                    new Model { Name ="SPRINTER"},
                    new Model { Name ="V CLASS" },
                    new Model { Name ="VITO"   }
                }
                });

            context.Makes.AddOrUpdate(m => m.Id,
                new Make
                {
                    Name = "Other",
                    Models = new List<Model>
                {
                    new Model { Name ="Other" },
                }
                });

            context.Makes.AddOrUpdate(m => m.Id,
                new Make
                {
                    Name = "SEAT",
                    Models = new List<Model>
                {
                    new Model { Name ="Ibiza" },
                    new Model { Name ="Leon" },
                }
                });

            context.Makes.AddOrUpdate(m => m.Id,
                new Make
                {
                    Name = "Skoda",
                    Models = new List<Model>
                {
                    new Model { Name ="Fabia" },
                    new Model { Name ="Octavia" },
                    new Model { Name ="Superb" },
                }
                });

            context.Makes.AddOrUpdate(m => m.Id,
                new Make
                {
                    Name = "Volkswagen",
                    Models = new List<Model>
                {
                    new Model { Name ="Bora" },
                    new Model { Name ="Fox" },
                    new Model { Name ="Golf" },
                    new Model { Name ="Passat" },
                    new Model { Name ="Polo" },
                    new Model { Name ="Sharan" },
                    new Model { Name ="Touran" },
                }
                });
        }
    }
}