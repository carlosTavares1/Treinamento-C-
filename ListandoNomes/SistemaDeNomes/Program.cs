using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoNomes.Controller;
using ListandoNomes.Model;

namespace SistemaDeNomes
{
    /// <summary>
    /// Esta classe é responsável por realizar o interfaceamento do sistema. Ela possui a instância da classe NomesController
    /// </summary>
    class Program
    {
        static NomesController nomesController = new NomesController();
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
        /// <summary>
        /// Este método possui o menu do sistema e faz a seleção do valor selecionado pelo usuário
        /// </summary>
        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("==========Sistema de Cadastro de Usuários==========");
            Console.WriteLine("Escolha uma das opções abaixo");
            Console.WriteLine("1 - Listar nomes");
            Console.WriteLine("2 - Adicionar nome");
            Console.WriteLine("0 - Sair do sistema");
            Console.Write("Agora, informe a opção desejada: ");
            var opcao = int.MinValue;
            while (opcao != 0)
            {
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        {
                            ListarNomes();
                            Menu();
                        }
                        break;
                    case 2:
                        {
                            AdicionarNome();
                            Menu();
                        }
                        break;
                    case 0:
                        {
                            Console.Clear();
                            Console.Write("Saindo do sistema...Pressione qualquer tecla para finalizar...");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Opção inválida");
                        }
                        break;
                }
            }
        }
        /// <summary>
        /// Este método é responsável por listar as informações presentes no banco de dados caso haja tais informações
        /// </summary>
        private static void ListarNomes()
        {
            Console.Clear();
            Console.WriteLine("==========Lista de Nomes==========");
            nomesController.GetNomePessoals().OrderBy(x => x.Nome).ToList<NomePessoal>().ForEach(x => Console.WriteLine($"Nome: {x.Nome} Origem: {x.Origem}"));
            Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }
        /// <summary>
        /// Este método realiza a adição de um novo usuário com origem no banco de dados
        /// </summary>
        private static void AdicionarNome()
        {
            Console.Clear();
            Console.WriteLine("==========Inserção de Usuários==========");
            Console.WriteLine("Informe o nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe a origem:");
            var origem = Console.ReadLine();
            var total = nomesController.InsertNomePessoal(new NomePessoal() 
            {
                Nome = nome,
                Origem = origem
            });
            if (total)
            {
                Console.WriteLine("Cadastro realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar!");
            }
            Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }
    }
}
