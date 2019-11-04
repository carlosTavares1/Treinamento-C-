namespace WebApiResolucaoDo31_10_19.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Carro> Carros { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Venda> Venda { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>()
                .Property(e => e.Modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Carro>()
                .HasMany(e => e.Vendas)
                .WithRequired(e => e.Carros)
                .HasForeignKey(e => e.Carro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marca>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Marca>()
                .HasMany(e => e.Carros)
                .WithRequired(e => e.Marcas)
                .HasForeignKey(e => e.Marca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Venda>()
                .Property(e => e.Valor)
                .HasPrecision(19, 4);
        }
    }
}
