using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class EventSpeakerMap : IEntityTypeConfiguration<EventSpeakerEntity>
    {
        public void Configure(EntityTypeBuilder<EventSpeakerEntity> builder)
        {
            builder.ToTable("EventSpeakers");
            builder.HasKey(x => new { x.EventId, x.SpeakerId });
        }
    }
}

