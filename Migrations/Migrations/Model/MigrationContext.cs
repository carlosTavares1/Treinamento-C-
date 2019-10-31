using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Migrations.Model
{
    public class MigrationContext : DbContext //Para usar o DbContext, temos que instalar o entity framework colocando o cursor em cima e fazendo control + .
    {
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}