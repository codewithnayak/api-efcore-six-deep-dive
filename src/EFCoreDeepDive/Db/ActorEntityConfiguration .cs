using EFCoreDeepDive.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreDeepDive.Db
{
    public class ActorEntityConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Name).IsRequired().HasMaxLength(200);
            builder.Property(_ => _.Id).UseIdentityColumn(1, 1);
            builder.Property(_ => _.Biography).HasMaxLength(2000);
            builder.Property(_ => _.DateOfBirth).HasConversion<DateOnlyConverter>().HasColumnType("date");

        }
    }

    //If it's absolutely needed to take dateonly , then convert it this way as SQL Server 2019 does not support DateOnly type 
    //mapping
    public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        /// <summary>
        /// Creates a new instance of this converter.
        /// </summary>
        public DateOnlyConverter() : base(
                d => d.ToDateTime(TimeOnly.MinValue),
                d => DateOnly.FromDateTime(d))
        { }
    }
}