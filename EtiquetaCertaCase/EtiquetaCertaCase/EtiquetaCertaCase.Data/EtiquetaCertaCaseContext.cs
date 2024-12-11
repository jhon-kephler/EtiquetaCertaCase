using EtiquetaCertaCase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaCertaCase.Data
{
    public class EtiquetaCertaCaseContext : DbContext
    {
        public EtiquetaCertaCaseContext(DbContextOptions<EtiquetaCertaCaseContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var asembly = typeof(EtiquetaCertaCaseContext).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(asembly);

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.Name).HasColumnName("category");
                entity.Property(e => e.Price).HasColumnName("price");
            });
        }

        public DbSet<Product> Product { get; set; }
    }
}
