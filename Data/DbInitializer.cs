using Microsoft.EntityFrameworkCore;
using SiteManagerServer.Models;

namespace SiteManagerServer.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SiteManagerContext(
                serviceProvider.GetRequiredService<DbContextOptions<SiteManagerContext>>()))
            {
                InitializeProducts(context);
                InitializeSites(context);
                InitializeUser(context);
            }
        }
    private static void InitializeProducts(SiteManagerContext context)
    {
        if (!context.Product.Any())
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Gray Portland Cement",
                    Manufacturer = "Nesher",
                    Model = "CEM I 52.5N",
                    Price = 30
                },
                new Product
                {
                    Id = 2,
                    Name = "External Thermal Plaster",
                    Manufacturer = "Termokir",
                    Model = "PT770",
                    Price = 120
                },
                new Product
                {
                    Id = 3,
                    Name = "External Acrylic Paint",
                    Manufacturer = "Tambour",
                    Model = "Supercryl Max",
                    Price = 150
                },
                new Product
                {
                    Id = 4,
                    Name = "Ready-Mix Concrete B-30",
                    Manufacturer = "Hanson",
                    Model = "B-30",
                    Price = 280
                },
                new Product
                {
                    Id = 5,
                    Name = "Powder Putty",
                    Manufacturer = "Gesher Gypsum",
                    Model = "MP102",
                    Price = 45
                },
                new Product
                {
                    Id = 6,
                    Name = "Reinforcement Steel",
                    Manufacturer = "Steel Industries",
                    Model = "FE500",
                    Price = 200
                },
                new Product
                {
                    Id = 7,
                    Name = "Thermal Insulation",
                    Manufacturer = "Ordan",
                    Model = "TH200",
                    Price = 85
                },
                new Product
                {
                    Id = 8,
                    Name = "Floor Tiles",
                    Manufacturer = "Naaman Group",
                    Model = "Granite 60x60",
                    Price = 95
                },
                new Product
                {
                    Id = 9,
                    Name = "Concrete Blocks",
                    Manufacturer = "Ytong",
                    Model = "Standard 20",
                    Price = 25
                },
                new Product
                {
                    Id = 10,
                    Name = "Waterproof Membrane",
                    Manufacturer = "Pazkar",
                    Model = "Aquaproof Pro",
                    Price = 180
                }
            };

            context.Product.AddRange(products);
            context.SaveChanges();
        }
    }

    private static void InitializeSites(SiteManagerContext context)
    {
        if (!context.Sites.Any())
        {
            var sites = new List<Site>
            {
                new Site
                {
                    Id = 1,
                    Name = "Torah Center Project",
                    Address = "Rabbi Akiva St 78, Bnei Brak",
                    WorkType = "Construction"
                },
                new Site
                {
                    Id = 2,
                    Name = "Vizhnitz Yeshiva",
                    Address = "Chazon Ish St 15, Bnei Brak",
                    WorkType = "General Renovation"
                },
                new Site
                {
                    Id = 3,
                    Name = "Bnei Brak Mall",
                    Address = "Jabotinsky St 23, Bnei Brak",
                    WorkType = "Plumbing"
                },
                new Site
                {
                    Id = 4,
                    Name = "Zichron Meir Residence",
                    Address = "Rashbam St 45, Bnei Brak",
                    WorkType = "Electrical"
                },
                new Site
                {
                    Id = 5,
                    Name = "Ramat Aharon Shopping Center",
                    Address = "Hashomer St 98, Bnei Brak",
                    WorkType = "Paint and Plaster"
                },
                new Site
                {
                    Id = 6,
                    Name = "Ponevezh Yeshiva Complex",
                    Address = "Ponevezh St 32, Bnei Brak",
                    WorkType = "Construction"
                },
                new Site
                {
                    Id = 7,
                    Name = "Mayanei Hayeshua Medical Center",
                    Address = "HaRav Landau St 17, Bnei Brak",
                    WorkType = "Renovation"
                },
                new Site
                {
                    Id = 8,
                    Name = "Kollel Chazon Ish",
                    Address = "Chazon Ish St 5, Bnei Brak",
                    WorkType = "Maintenance"
                },
                new Site
                {
                    Id = 9,
                    Name = "Pardes Katz Community Center",
                    Address = "Kehilot Yaakov St 63, Bnei Brak",
                    WorkType = "Construction"
                },
                new Site
                {
                    Id = 10,
                    Name = "Kiryat Herzog Synagogue",
                    Address = "Rabbi Shach St 12, Bnei Brak",
                    WorkType = "Renovation"
                },
                new Site
                {
                    Id = 11,
                    Name = "Ramat Aharon Educational Campus",
                    Address = "HaRav Dessler St 44, Bnei Brak",
                    WorkType = "Construction"
                },
                new Site
                {
                    Id = 12,
                    Name = "Zichron Moshe Complex",
                    Address = "Admor MiVizhnitz St 28, Bnei Brak",
                    WorkType = "General Construction"
                }
            };

            context.Sites.AddRange(sites);
            context.SaveChanges();
        }
    }     
   private static void InitializeUser(SiteManagerContext context)
        {
            if (!context.Users.Any())
            {
                var user = new User
                {
                   Name = "Zvi",
                   Password = "123456",
                   Email = "a@a.a" 
                };

                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    
    }
}