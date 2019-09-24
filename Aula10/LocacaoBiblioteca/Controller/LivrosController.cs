using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        private LocacaoContext contextDB = new LocacaoContext();
        public LivrosController()
        {
           
        }
        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já instanciada criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adicionamos o livro em nossa lista
            parametroLivro.Id = contextDB.IdContadorLivros++;
            contextDB.ListaDeLivros.Add(parametroLivro);
        }
        /// <summary>
        /// Metodo retorna a lista de livros
        /// </summary>
        /// <returns>Retorna a lista de livros</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>();
        }
        /// <summary>
        /// Este método remove livro por id
        /// </summary>
        /// <param name="identificadorId">Este parametro é do identificador</param>
        public void RemoverLivroPorId(int identificadorId)
        {
            contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificadorId).Ativo = false;
        }
    }
}