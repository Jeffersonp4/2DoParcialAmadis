using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Api_Parcial.Models
{
    public partial class db_parcialContext : DbContext
    {
        public db_parcialContext()
        {
        }

        public db_parcialContext(DbContextOptions<db_parcialContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TablaRobo> TablaRobos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;uid=root;database=db_parcial", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.20-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            modelBuilder.Entity<TablaRobo>(entity =>
            {
                entity.ToTable("tabla_robos");

                entity.HasIndex(e => e.Cedula, "cedu")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Cedula)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cedula");

                entity.Property(e => e.DondeOcurrio)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("donde_ocurrio");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Logintud).HasColumnName("logintud");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.QueRobaron)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("que_robaron");

                entity.Property(e => e.ValorDollar)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("valor_dollar");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
