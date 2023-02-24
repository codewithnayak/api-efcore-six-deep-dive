using EFCoreDeepDive.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDeepDive.Db
{
    public class CinemaHallEntityConfiguration : IEntityTypeConfiguration<CinemaHall>
    {
        public void Configure(EntityTypeBuilder<CinemaHall> builder)
        {
            builder.Property(_ => _.Id).UseIdentityColumn(1, 1);
            builder.Property(_ => _.Name).HasMaxLength(200);
            builder.Property(_ => _.Cost).HasPrecision(5, 2);
            builder.Property(_ => _.CinemaHallType).HasDefaultValue(CinemaHallType.TwoDimensions);
        }
    }
}
