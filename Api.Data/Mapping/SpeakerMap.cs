
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Api.Data.Mapping
{
    public class SpeakerMap : IEntityTypeConfiguration<SpeakerEntity>
    {

        public void Configure(EntityTypeBuilder<SpeakerEntity> builder)
        {
            builder.ToTable("Speakers");
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.SpeakerName);
            builder.HasMany(e => e.SocialMedias).WithOne(p => p.Speaker).OnDelete(DeleteBehavior.Cascade); ;

        }
    }
}


