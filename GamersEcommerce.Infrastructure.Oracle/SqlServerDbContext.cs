using GamersEcommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GamersEcommerce.Infrastructure.Oracle
{
    public class SqlServerDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        
        public SqlServerDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductSaleHistory> ProductsSaleHistory { get; set; }
        public DbSet<ProductStockQuantity> ProductsStockQuantity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;

            optionsBuilder
                .EnableDetailedErrors()
                .UseSqlServer(
                    connectionString: _configuration.GetConnectionString(nameof(SqlServerDbContext)),
                    sqlServerOptionsAction: sqlOptions =>
                    {
                        sqlOptions.EnableRetryOnFailure(
                            maxRetryCount: 10,
                            maxRetryDelay: TimeSpan.FromSeconds(30),
                            errorNumbersToAdd: null);
                    });
        }
    }
}