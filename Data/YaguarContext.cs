using System;
using System.Collections.Generic;
using AMB_YAGUAR.Models;
using Microsoft.EntityFrameworkCore;

namespace AMB_YAGUAR.Data;

public partial class YaguarContext : DbContext
{
    public YaguarContext()
    {
    }

    public YaguarContext(DbContextOptions<YaguarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Idproducto).HasName("PK__PRODUCTO__7D8DC0F1886D8A0D");

            entity.ToTable("PRODUCTOS");

            entity.Property(e => e.Idproducto).HasColumnName("IDPRODUCTO");
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CATEGORIA");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Fechaingreso)
                .HasColumnType("date")
                .HasColumnName("FECHAINGRESO");
            entity.Property(e => e.Imagen).HasColumnName("IMAGEN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.Stock).HasColumnName("STOCK");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
