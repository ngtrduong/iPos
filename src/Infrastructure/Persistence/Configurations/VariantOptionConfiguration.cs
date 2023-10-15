using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;
public class VariantOptionConfiguration : IEntityTypeConfiguration<VariantOption>
{
    public void Configure(EntityTypeBuilder<VariantOption> builder)
    {
        builder.ToTable(nameof(VariantOption));

        builder.Property(p => p.Value)
            .HasMaxLength(255)
            .IsRequired();

        builder.HasOne(o => o.Variant)
            .WithMany(m => m.VariantOptions)
            .HasForeignKey(fk => fk.VariantId);
    }
}