
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class EventMap : IEntityTypeConfiguration<EventEntity>
    {

        public void Configure(EntityTypeBuilder<EventEntity> builder)
        {
            builder.ToTable("Events");
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.EventDate);
            builder.HasMany(e => e.Lots).WithOne(l => l.Event).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(e => e.socialMedias).WithOne(l => l.Event).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

