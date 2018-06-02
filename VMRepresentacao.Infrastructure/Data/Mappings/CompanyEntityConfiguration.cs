using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VMRepresentacao.Domain.Entities;

namespace VMRepresentacao.Infrastructure.Data.Mappings
{
    internal class CompanyEntityConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Address).WithOne(y => y.Company);

            // For Value Object
            builder.OwnsOne(x => x.Email, e => { e.Property(p => p.Address).HasColumnName("Email"); });

            builder.OwnsOne(x => x.CNPJ,
               e =>
               {
                   e.Property(p => p.Number)
                        .HasColumnName("CNPJ")
                        .HasMaxLength(14);
               });
        }
    }
}
