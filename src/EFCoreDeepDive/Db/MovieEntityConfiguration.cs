using EFCoreDeepDive.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDeepDive.Db
{
    public class MovieEntityConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Name).IsRequired().HasMaxLength(200);
            builder.Property(_ => _.Id).UseIdentityColumn(1, 1);
            builder.Property(_ => _.PosterUrl).IsUnicode(false);

        }
    }
}