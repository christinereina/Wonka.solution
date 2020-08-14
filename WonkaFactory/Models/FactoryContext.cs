using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treat> Treats {get;set;}
    public DbSet<Flavor> Flavors {get;set;}
    public DbSet<FlavorTreat> FlavorTreat {get;set;}
    public FactoryContext(DbContextOptions options) : base(options) {}
  }
}