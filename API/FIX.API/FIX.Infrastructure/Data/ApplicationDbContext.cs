using FIX.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FIX.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<CarPart> CarParts { get; set; }
    public DbSet<CarPartShop> CarPartShops { get; set; }
    public DbSet<Mechanic> Mechanics { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<Workshop> Workshops { get; set; }
}