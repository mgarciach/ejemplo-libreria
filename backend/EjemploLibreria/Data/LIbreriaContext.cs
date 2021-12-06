using EjemploLibreria.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploLibreria.Data
{
    public class LibreriaContext : DbContext
    {

        public LibreriaContext(DbContextOptions<LibreriaContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ELibro>(entity =>
            {
                entity.ToTable("libros");

                entity.HasKey(e => e.IdLibro);

                entity.Property(e => e.IdLibro)
                    .HasColumnName("ID_LIBRO")
                    .IsRequired()
                    .ValueGeneratedNever();

                entity.Property(e => e.Titulo)
                  .HasColumnName("TITULO")
                  .IsRequired()
                  .ValueGeneratedNever();

                entity.Property(e => e.Genero)
                   .HasColumnName("GENERO")
                   .IsRequired()
                   .ValueGeneratedNever();

                entity.Property(e => e.FechaPublicacion)
                   .HasColumnName("FECHA_PUBLICACION")
                   .IsRequired()
                   .ValueGeneratedNever();

                entity.Property(e => e.Dimension)
                   .HasColumnName("DIMENSION")
                   .ValueGeneratedNever();

                entity.Property(e => e.Autor)
                   .HasColumnName("AUTOR")
                   .ValueGeneratedNever();

                entity.Property(e => e.Precio)
                   .HasColumnName("PRECIO")
                   .ValueGeneratedNever();

            });
        }
        //entities
        public DbSet<ELibro> Libros { get; set; }
    }

}
