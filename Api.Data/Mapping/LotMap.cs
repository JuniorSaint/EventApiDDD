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
            builder.HasKey(l => l.Id);
            builder.HasIndex(l => l.LotName);
            builder.HasOne(l => l.Event).WithMany(e => e.Lots);
        }
    }
}

