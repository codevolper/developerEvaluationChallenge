using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

/// <summary>
/// The Product entity configuration for database mapping
/// </summary>
public class SaleProductConfiguration : IEntityTypeConfiguration<SaleProduct>
{
    /// <summary>
    /// The Product Table configuration for database mapping
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<SaleProduct> builder)
    {
        builder.ToTable("SalesProduct");

        builder.HasKey(s => s.Id);
        builder.Property(s => s.SaleId)
            .HasColumnName("SaleId")
            .HasColumnType("uuid")
            .HasDefaultValueSql("gen_random_uuid()");
    }
}
