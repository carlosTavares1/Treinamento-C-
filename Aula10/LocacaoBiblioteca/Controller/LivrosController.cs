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
        private int idContador = 0;
        private List<Livro> Livros { get; set; }
        public LivrosController()
        {
            Livros = new List<Livro>();

            Livros.Add(new Livro()
            {
                Id = idContador++,
                Nome = "Meu primeiro livro"
            });

            Livros.Add(new Livro()
            {
                Id = idContador++,
                Nome = "Meu segundo livro"
            });
        }
        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já instanciada criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adicionamos o livro em nossa lista
            parametroLivro.Id = idContador++;
            Livros.Add(parametroLivro);
        }
        /// <summary>
        /// Metodo retorna a lista de livros
        /// </summary>
        /// <returns>Retorna a lista de livros</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return Livros;
        }
    }
}
