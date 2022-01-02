using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Data.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.Property(a => a.Nombre).IsRequired().HasMaxLength(250);
            builder.Property(a => a.Descripcion).IsRequired().HasMaxLength(500);
            builder.Property(a => a.Precio).HasColumnType("decimal(18,2)");
            builder.HasOne(a => a.Marca).WithMany().HasForeignKey(a => a.MarcaId);
            builder.HasOne(a => a.Categoria).WithMany().HasForeignKey(a => a.CategoriaId);
        }
    }
}
