using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Model;

namespace Estoque.Controller
{
    /// <summary>
    /// Este classe faz o controle do que deve acontecer na busca e na inserção de valores na base de dados
    /// </summary>
    public class ProductController
    {
        ContextDB context = new ContextDB();
        /// <summary>
        /// Este método realiza a busca no banco com base nos registros ativos da base de dados
        /// </summary>
        /// <returns>Retorna somente os valores que possuem registro ativo igual a true</returns>
        public IQueryable<Produto> GetProdutos()
        {
            return context.Produtos.Where(x => x.Ativo == true);
        }
        /// <summary>
        /// Este método inseri um novo registro na base de dados
        /// </summary>
        /// <param name="produto">Recebe como parâmetro um objeto</param>
        /// <returns>Retorna verdadeiro caso os valores do parâmetros estejam corretos</returns>
        public bool InserirProduto(Produto produto)
        {
            if (string.IsNullOrWhiteSpace(produto.Nome))
            {
                return false;
            }
            
            if (produto.Valor <= 0)
            {
                return false;
            }
            context.Produtos.Add(produto);
            context.SaveChanges();
            return true;
        }
    }
}
