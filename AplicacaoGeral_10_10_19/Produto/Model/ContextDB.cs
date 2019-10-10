using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    /// <summary>
    /// Esta classe faz a instanciação das tabelas na base de dados
    /// </summary>
    public class ContextDB : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}
