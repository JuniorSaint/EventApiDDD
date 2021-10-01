using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class LotMap : IEntityTypeConfiguration<LotEntity>
    {
        public void Configure(EntityTypeBuilder<LotEntity> builder)
        {
            builder.ToTable("Lots");
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.LotName);
            builder.HasOne(e => e.Event);
        }
    }
}

