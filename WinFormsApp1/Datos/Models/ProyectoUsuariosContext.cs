using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Datos.Models
{
    public partial class ProyectoUsuariosContext : DbContext
    {
        public ProyectoUsuariosContext()
        {
         
        }

        public ProyectoUsuariosContext(DbContextOptions<ProyectoUsuariosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SM-NFEDIUK\\SQLEXPRESS; Database=ProyectoUsuarios; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.DniUsu);

                entity.ToTable("Usuario");

                entity.HasIndex(e => e.CorreoUsu, "UQ__Usuario__5206389CD5AB1653")
                    .IsUnique();

                entity.Property(e => e.DniUsu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DNI_usu");

                entity.Property(e => e.ApellidoUsu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Apellido_usu");

                entity.Property(e => e.CelularUsu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Celular_usu")
                    .HasDefaultValueSql("('Sin celular')");

                entity.Property(e => e.ContraseñaUsu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Contraseña_usu");

                entity.Property(e => e.CorreoUsu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Correo_usu");

                entity.Property(e => e.NombreUsu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_usu");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
