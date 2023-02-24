using EFCoreDeepDive.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDeepDive.Db
{
    public class CinemaEntityConfiguration : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Name).IsRequired().HasMaxLength(200);
            builder.Property(_ => _.Id).UseIdentityColumn(1, 1);
            builder.Property(_ => _.Price).HasPrecision(5, 2);
           
        }
    }
}
