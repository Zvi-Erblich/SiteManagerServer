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
                        Name = "צמנט פורטלנד אפור",
                        Manufacturer = "נשר",
                        Model = "CEM I 52.5N"
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "טיח תרמי חיצוני",
                        Manufacturer = "תרמוקיר",
                        Model = "PT770"
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "צבע אקרילי חיצוני",
                        Manufacturer = "טמבור",
                        Model = "סופרקריל מקס"
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "בטון מובא ב-30",
                        Manufacturer = "הנסון",
                        Model = "B-30"
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "שפכטל אבקתי",
                        Manufacturer = "גבס גשר",
                        Model = "MP102"
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
                        Name = "מגדלי הים התיכון",
                        Address = "שדרות בן גוריון 78, תל אביב",
                        WorkType = "בנייה"
                    },
                    new Site
                    {
                        Id = 2,
                        Name = "בית ספר רמות",
                        Address = "רחוב הערבה 15, באר שבע",
                        WorkType = "שיפוץ כללי"
                    },
                    new Site
                    {
                        Id = 3,
                        Name = "קניון הצפון",
                        Address = "דרך העמק 23, כרמיאל",
                        WorkType = "אינסטלציה"
                    },
                    new Site
                    {
                        Id = 4,
                        Name = "מתחם מגורים רמת אביב",
                        Address = "רחוב אינשטיין 45, תל אביב",
                        WorkType = "חשמל"
                    },
                    new Site
                    {
                        Id = 5,
                        Name = "מרכז מסחרי השלום",
                        Address = "שדרות ירושלים 98, חיפה",
                        WorkType = "צבע וטיח"
                    }
                };

                context.Sites.AddRange(sites);
                context.SaveChanges();
            }
        }
    }
}