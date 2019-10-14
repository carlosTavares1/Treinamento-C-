using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaLibrary.Model
{
    /// <summary>
    /// Esta classe promove a relação com a base de dados
    /// </summary>
    public class ContextDB : DbContext
    {
        /// <summary>
        /// Esta propriedade promove o controle as tabelas da base de dados
        /// </summary>
        public DbSet<Bicicleta> Bicicletas { get; set; }
    }
}
