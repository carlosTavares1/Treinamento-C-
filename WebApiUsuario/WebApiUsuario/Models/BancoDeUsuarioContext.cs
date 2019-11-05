using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApiUsuario.Models
{
    public partial class BancoDeUsuarioContext : DbContext
    {
        public BancoDeUsuarioContext()
        {
        }

        public BancoDeUsuarioContext(DbContextOptions<BancoDeUsuarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UsuarioAlteracao).HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioCriacao).HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
