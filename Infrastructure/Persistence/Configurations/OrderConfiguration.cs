using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");

        builder.HasKey(o => o.Id);

        builder.Property(o => o.CustomerName)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(o => o.Status)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(o => o.CreatedAt)
            .IsRequired();
    }
}