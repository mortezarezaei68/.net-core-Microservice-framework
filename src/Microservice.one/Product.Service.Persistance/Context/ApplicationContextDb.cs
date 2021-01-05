using Framework.Domain;
using Framework.Domain.CoreContextHelper;
using Microservice.Domain;
using Microsoft.EntityFrameworkCore;
using Persistance.EfCore.DomainConfiguration;

namespace Persistance.EfCore.Context
{
    public class ApplicationContextDb : CoreDbContext
    {
        public ApplicationContextDb(DbContextOptions<ApplicationContextDb> options) : base(options)
        {
        }

        public DbSet<Product> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}