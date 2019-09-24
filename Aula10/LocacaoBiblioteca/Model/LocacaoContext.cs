using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        public List<Livro> ListaDeLivros { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }
        public int IdContadorLivros { get; set; }

        public int IdContadorUsuarios { get; set; } = 1;

        /// <summary>
        /// Metodo construtor que prepara nossa classe locacao text
        /// </summary>
        public LocacaoContext()
        {
            //Criamos a lista de livro
            ListaDeLivros = new List<Livro>();
            //Criamos a lista de usuário
            ListaDeUsuarios = new List<Usuario>();
            //Adicionamos os livros
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Meu primeiro livro"
            });
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Meu segundo livro"
            });
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Guia do mochileiro das galaxias"
            });
            //Adicionamos o usuário
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "admin"
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "123"
            });
        }

    }
}