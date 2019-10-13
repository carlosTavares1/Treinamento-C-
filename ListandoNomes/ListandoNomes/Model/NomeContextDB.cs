using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoNomes.Model
{
    /// <summary>
    /// Esta classe é responsável por realizar a criação da base de dados e da tabela também
    /// </summary>
    public class NomeContextDB : DbContext
    {
        /// <summary>
        /// Esta propriedade é responsável por realizar a conexão com as tabelas
        /// </summary>
        public DbSet<NomePessoal> NomePessoals { get; set; }
    }
}
