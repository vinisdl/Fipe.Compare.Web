using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fipe.Compare.Context.Configurations;
using Fipe.Compare.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Fipe.Compare.Context
{
    public class FipeCompareContext : DbContext
    {
        public FipeCompareContext(DbContextOptions<FipeCompareContext> options)
            : base(options)
        { }

        public DbSet<Motocycle> Motocycle { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.DisplayName();
            }

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Motocycle>(new MotocycleConfiguration().Configure);

        }

    }  
}