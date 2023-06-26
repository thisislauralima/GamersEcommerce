using GamersEcommerce.Domain;
using GamersEcommerce.Infrastructure.Oracle.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Oracle
{
    public class OracleDbContext : DbContext
    {
        //public OracleDbContext(DbContextOptions<OracleDbContext> options)
        //    : base(options)
        //{ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("GammerEcommerce");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OracleDbContext).Assembly);
            modelBuilder.SetDefaultStringLength();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // retorna true se o dbContext possui o UseOracle ou similar
            // https://stackoverflow.com/questions/49561771/what-are-expected-results-when-optionsbuilder-is-defined-in-both-dbcontext-oncon
            if (optionsBuilder.IsConfigured) return;

            optionsBuilder.UseOracle(
                connectionString: "User Id=SYS;Password=SUA_SENHA;DBA Privilege=SYSDBA;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=51521)))(CONNECT_DATA=(SERVICE_NAME=xe)))");
        }
        public DbSet<Product> Products { get; set; } // criação da tabela
    }
}