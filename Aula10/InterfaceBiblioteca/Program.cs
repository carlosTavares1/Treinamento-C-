using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {
        static LivrosController livrosController = new LivrosController();
        static UsuarioController usuarioController = new UsuarioController();
        static void Main(string[] args)
        {
            

            Console.WriteLine("                     ----------SISTEMA DE LOCAÇÃO DE LIVRO 1.0----------");

            while (!RealizaLoginSistema())
            {
                Console.Clear();
                Console.WriteLine("Login ou senha inválidos!");
            }
            MostraMenuSistema();

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra o menu disponível do sistema
        /// </summary>
        private static void MostraMenuSistema()
        {
            var opcao = int.MinValue;
            while (opcao != 0) {
                Console.Clear();
                Console.WriteLine("                     ----------SISTEMA DE LOCAÇÃO DE LIVRO 1.0----------");

                Console.WriteLine("Menu sistema");
                Console.WriteLine("1 - Listar usuários");
                Console.WriteLine("2 - Listar livros");
                Console.WriteLine("3 - Trocar de usuário");
                Console.WriteLine("4 - Cadastrar livros");
                Console.WriteLine("5 - Cadastrar usuário");
                Console.WriteLine("6 - Remover usuário");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Informe a opção desejada: ");
                opcao = int.Parse(Console.ReadKey().KeyChar.ToString());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();
                            MostrarUsuarios();
                        }
                        break;
                    case 2:
                        {
                            MostrarLivro();
                        }
                        break;
                    case 3:
                        {
                            while (!RealizaLoginSistema())
                            {
                                Console.Clear();
                                Console.WriteLine("Login ou senha inválidos!");
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            AdicionarLivro();
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            AdicionarUsuario();
                        }
                        break;
                    case 6:
                        {
                            Console.Clear();
                            RemoverUsuarioPeloId();
                        }
                        break;
                    default:
                        break;
                }
            }
            //Aqui vamos pegar numero digitado
            //Executar proxima funcao
        }
        private static void RemoverUsuarioPeloId()
        {
            Console.WriteLine("                             ----------Remover usuário pelo id no sistema----------");
            //Metodo que retorna a lista de usuarios
            MostrarUsuarios();

            Console.WriteLine("Informe o id que voce deseja remover: ");
            var usuarioId = int.Parse(Console.ReadLine());
            //Aqui chamamos removerusuarioporid da nossa classe que controla os usuarios do sistema
            usuarioController.RemoverUsuarioPorId(usuarioId);
            //Informamos que o usuario foi desativado com sucesso
            Console.WriteLine("Usuário desativado com sucesso");
        }

        /// <summary>
        /// metodo que realiza os procedimentos completos de login dentro do sistema como solicitação de
        /// login e senha pelo console assim como respectivas validações que o mesmo
        /// precisa para entrar no sistema
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha informados estiverem corretos.</returns>
        private static bool RealizaLoginSistema()
        {
            Console.Clear();
            Console.WriteLine("\r\nInforme seu login e senha para acessar o sistema:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();


           // UsuarioController usuarioController = new UsuarioController();

            return usuarioController.LoginSistema(new Usuario() { Login = loginDoUsuario , Senha = senhaDoUsuario });

        }
        /// <summary>
        /// Este método mostra os livros no sistema
        /// </summary>
        private static void MostrarLivro()
        {
            //Livro livro = new Livro()
            //{
            //    Nome = "XXX"
            //};
            //Console.Clear();
            //Console.WriteLine(livro.Nome);
            Console.Clear();
            Console.WriteLine("                     ----------SISTEMA DE LOCAÇÃO DE LIVRO 1.0----------");
            livrosController.RetornaListaDeLivros().ForEach(i => Console.WriteLine($"Código: {i.Id} Nome: {i.Nome}"));
            Console.ReadKey();
        }
        /// <summary>
        /// Método para mostrar a lista de usuarios ja cadastrados no sistema
        /// </summary>
        private static void MostrarUsuarios()
        {
            usuarioController.RetornaListaDeUsuario().ForEach(i => Console.WriteLine($"Id: {i.Id} | Login: {i.Login}"));
            Console.ReadKey();
        }
        /// <summary>
        /// Este método adiciona um novo livro
        /// </summary>
        private static void AdicionarLivro()
        {
            Console.WriteLine("                     ----------SISTEMA DE LOCAÇÃO DE LIVRO 1.0----------");
            Console.WriteLine("Cadastrar livro dentro do sistema: ");
            Console.WriteLine("Informe o nome do livro: ");
            var nomeDoLivro = Console.ReadLine();
            livrosController.AdicionarLivro(new Livro()
            {
                Nome = nomeDoLivro
            });
            Console.WriteLine("Livro cadastrado com sucesso!");
            Console.ReadKey();
        }
        /// <summary>
        /// Este metodo adiciona novos usuários ao sistema
        /// </summary>
        private static void AdicionarUsuario()
        {
            Console.WriteLine("                     ----------SISTEMA DE LOCAÇÃO DE LIVRO 1.0----------");
            Console.WriteLine("Informe o novo login de usuário: ");
            var login = Console.ReadLine();
            Console.WriteLine("Informe a nova senha do usuário: ");
            var senha = Console.ReadLine();
            usuarioController.Usuario(new Usuario()
            {
                Login = login,
                Senha = senha
            });
        }
    }
}
