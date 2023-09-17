using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using System.Reflection;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //Assembly içerisindeki IEntityTypeConfiguration interfaceinden miras alan bütün classları bulur ve uygular.

            /*modelBuilder.ApplyConfiguration(new ProductConfiguration()); //Sadece parametre olarak verilen configuration'ı uygular.*/



            base.OnModelCreating(modelBuilder);
        }

    }
}
