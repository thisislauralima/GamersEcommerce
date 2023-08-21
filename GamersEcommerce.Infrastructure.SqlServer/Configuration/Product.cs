using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GamersEcommerce.Domain.Entities;

namespace GamersEcommerce.Infrastructure.SqlServer.Configuration
{
    public class Product : IEntityTypeConfiguration<Domain.Entities.Product>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Product> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("Product_Id");

            builder.ToTable("PRODUCT");

            builder.HasIndex(x => x.Id)
                .HasDatabaseName("Product_Id")
                .IsUnique();

            builder.Property(x => x.CategoryId)
                .HasColumnName("Category_Id")
                .ValueGeneratedNever();

            builder.Property(x => x.ProductRegistrationDate)
                .HasColumnName("Product_Registration_Date")
                .HasColumnType("datetime");
        }
    }
}
