using Microsoft.EntityFrameworkCore;

namespace SiteManagerServer.Models;

public class SiteManagerContext : DbContext
{
    public SiteManagerContext(DbContextOptions<SiteManagerContext> options)
        : base(options)
    {
    }

    public DbSet<Site> Sites { get; set; } = null!;
    public DbSet<Product> Product { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;


}