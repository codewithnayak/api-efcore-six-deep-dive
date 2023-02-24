using EFCoreDeepDive.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDeepDive.Db
{
    public class CinemaOfferEntityConfiguration : IEntityTypeConfiguration<CinemaOffer>
    {
        public void Configure(EntityTypeBuilder<CinemaOffer> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.OfferName).HasMaxLength(200);
            builder.Property(_ => _.Id).UseIdentityColumn(1, 1);
            builder.Property(_ => _.DiscountPercentage).HasPrecision(5, 2);
           
        }
    }
}
