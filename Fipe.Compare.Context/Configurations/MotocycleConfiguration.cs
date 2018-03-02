using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Fipe.Compare.Domain.Entitys;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fipe.Compare.Context.Configurations
{    
    public class MotocycleConfiguration : IEntityTypeConfiguration<Motocycle>
    {
        public void Configure(EntityTypeBuilder<Motocycle> builder)
        {
            builder.HasKey(a => a.IdMotocycle);
            builder.Property(a => a.Plate).HasMaxLength(8).IsRequired();            
        }
    }
}
