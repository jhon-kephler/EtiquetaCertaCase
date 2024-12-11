using EtiquetaCertaCase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EtiquetaCertaCase.Data.Map
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("id");

            builder
                .Property(b => b.Id)
                .HasColumnType("integer")
                .HasColumnName("id")
                .IsRequired();

            builder
                .Property(b => b.Name)
                .HasColumnType("varchar")
                .HasColumnName("name")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(b => b.Category)
                .HasColumnType("varchar")
                .HasColumnName("category")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(b => b.Price)
                .HasColumnType("numeric")
                .HasColumnName("price")
                .IsRequired();
        }
    }
}
