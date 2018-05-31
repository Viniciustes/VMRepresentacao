using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VMRepresentacao.Domain.Entities;

namespace VMRepresentacao.Infrastructure.Data.Mappings
{
    internal class CustomerEntityConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("Name");

            // For Value Object
            builder.OwnsOne(x => x.Email, e => { e.Property(p => p.Address).HasColumnName("Email"); });

            builder.OwnsOne(x => x.CNPJ, 
                e => { e.Property(p => p.Number)
                    .HasColumnName("CNPJ")
                    .HasMaxLength(14); });

            builder.OwnsOne(x => x.CPF, 
                e => { e.Property(p => p.Number)
                    .HasColumnName("CPF")
                    .HasMaxLength(11); });
        }
    }
}
