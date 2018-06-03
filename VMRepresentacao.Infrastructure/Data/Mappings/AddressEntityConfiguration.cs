using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VMRepresentacao.Domain.Entities;

namespace VMRepresentacao.Infrastructure.Data.Mappings
{
    public class AddressEntityConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Company).WithOne(y => y.c)

            // For Value Object
            builder.OwnsOne(x => x.ZipCode,
               e =>
               {
                   e.Property(p => p.Number)
                        .HasColumnName("ZipCode")
                        .HasMaxLength(8);
               });
        }
    }
}
