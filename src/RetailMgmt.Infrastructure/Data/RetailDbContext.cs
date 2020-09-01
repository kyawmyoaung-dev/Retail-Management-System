using Microsoft.EntityFrameworkCore;
using RetailMgmt.Core.Entities.InventoryModule;
using RetailMgmt.Core.Entities.OrganizationModule;


namespace RetailMgmt.Infrastructure.Data
{
    public class RetailDbContext : DbContext
    {
        public RetailDbContext(DbContextOptions<RetailDbContext> options) : base(options)
        {

        }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<FinancialYear> FinancialYears { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
