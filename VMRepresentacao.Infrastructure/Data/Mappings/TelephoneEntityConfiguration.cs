using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VMRepresentacao.Domain.Entities;

namespace VMRepresentacao.Infrastructure.Data.Mappings
{
    public class TelephoneEntityConfiguration : IEntityTypeConfiguration<Telephone>
    {
        public void Configure(EntityTypeBuilder<Telephone> builder)
        {
            builder.ToTable("Telephone");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Company).WithMany(y => y.Telephones).HasForeignKey(x => x.CompanyId).OnDelete(DeleteBehavior.Restrict).IsRequired(false); 

            builder.HasOne(x => x.Customer).WithMany(y => y.Telephones).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        }
    }
}
