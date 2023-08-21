using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace GamersEcommerce.Infrastructure.SqlServer.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void SetDefaultStringLength(this ModelBuilder modelBuider)
        {
            foreach (var entity in modelBuider.Model.GetEntityTypes())
            {
                var properties = entity.GetProperties().Where(p => p.ClrType == typeof(string));

                foreach (var property in properties)
                {
                    if (string.IsNullOrEmpty(property.GetColumnType()) && !property.GetMaxLength().HasValue)
                    {
                        property.SetColumnType("VARCHAR(150)");
                    }
                }
            }
        }
    }
}