using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static List<string> nome = new List<string>();
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        public static void Menu()
        {
            Console.WriteLine("         ==========Cadastro de Usuários==========");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Listar usuários");
            Console.WriteLine("2 - Adicionar usuários");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite a opção desejada: ");
            var opcao = int.MinValue;
            while (opcao != 0)
            {
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();
                            ListarUsuarios();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            AdicionarUsuarios();
                        }
                        break;
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("Saindo do sistema...");
                            Console.Write("Pressione qualquer tecla para sair...");
                            Console.ReadKey();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// Este método apresenta a lista de usuários no sistema
        /// </summary>
        public static void ListarUsuarios()
        {
            Console.WriteLine("Lista de usuário:");
            if (nome.Count == 0)
            {
                nome.Add("Marcio");
                nome.Add("Jose");
                nome.Add("Adriano");
                nome.Add("Breno");
                nome.Add("Jessica");
                nome.Add("Carlos");
                nome.Add("Antonio");
                nome.Add("Gabriel");
                nome.Add("Kassia");
                nome.Add("Nayara");
            }
            nome.OrderBy(i => i).ToList<string>().ForEach(i => Console.WriteLine(i));
            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        /// <summary>
        /// Este método proporciona a adição de um novo nome
        /// </summary>
        public static void AdicionarUsuarios()
        {
            Console.Clear();
            Console.WriteLine("Informe um novo nome:");
            var novoNome = Console.ReadLine();
            nome.Add(novoNome);
            Console.Clear();
            Menu();
        }

        
    }
}
