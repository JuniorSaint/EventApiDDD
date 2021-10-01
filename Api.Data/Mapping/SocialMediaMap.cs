using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class SocialMediaMap : IEntityTypeConfiguration<SocialMediaEntity>
    {

        public void Configure(EntityTypeBuilder<SocialMediaEntity> builder)
        {
            builder.ToTable("SocialMedias");
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.SocialMedia);
            builder.HasOne(e => e.Speaker);
            builder.HasOne(e => e.Event);
        }
    }
}

