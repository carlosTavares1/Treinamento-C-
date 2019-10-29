namespace WebApiBicicleta.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BicicletaContext : DbContext
    {
        public BicicletaContext()
            : base("name=BicicletaContext")
        {
        }

        public virtual DbSet<Bicicletas> Bicicletas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
