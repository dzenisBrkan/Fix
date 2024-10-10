
//using System.Data.Entity;

using FIX.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FIX.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<CarParts> CarParts { get; set; }
    public DbSet<Mechanics> Mechanics { get; set; }
    public DbSet<Meetings> Meetings { get; set; }
    public DbSet<Messages> Messages { get; set; }
    public DbSet<Notifications> Notifications { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<Reviews> Reviews { get; set; }
    public DbSet<Suppliers> Suppliers { get; set; }
    public DbSet<Users> Users { get; set; }
}
