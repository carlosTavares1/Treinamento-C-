using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCFlores.Model;
using MVCFlores.Controller;

namespace InterfaceFloricultura
{
    /// <summary>
    /// Esta classe é a que possui o método main e possui a implementação da interface do sistema
    /// </summary>
    public class Program
    {
        static FloresController flores = new FloresController();
        static void Main(string[] args)
        {
            Menu();
            Console.Clear();
        }
        /// <summary>
        /// Este método exibe o menu e fornece acesso aos demais métodos do sistema através de métodos declarados nesta classe
        /// </summary>
        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("==========Sistema de Cadastro de Flores==========");
            Console.WriteLine("Escolha uma opção abaixo: ");
            Console.WriteLine("1 - Incluir flor");
            Console.WriteLine("2 - Listar flor");
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
                            InserirNovaFlor();
                            Menu();
                        }
                        break;
                    case 2:
                        {
                            MostrarFlores();
                            Menu();
                        }
                        break;
                    case 0:
                        {
                            Console.Write("Saindo do sistema...Pressione qualquer tecla para sair...");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// Este método apresenta a lista de flores cadastradas na base de dados do sistema
        /// </summary>
        private static void MostrarFlores()
        {
            Console.Clear();
            flores.GetFlors().OrderByDescending(x => x.Quantidade).ToList<Flor>().ForEach(x => Console.WriteLine($"Nome: {x.Nome} Quantidade: {x.Quantidade}"));
            var total = flores.GetFlors().Sum(x => x.Quantidade);
            Console.WriteLine($"A soma total de flores é: {total}");
            Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }
        /// <summary>
        /// Este método insere um novo registro de uma flor na base de dados
        /// </summary>
        private static void InserirNovaFlor()
        {
            Console.Clear();
            Console.WriteLine("==========Inserção Flor no Sistema==========");
            Console.WriteLine("Informe o nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe a quantidade: ");
            var quantidade = int.Parse(Console.ReadLine());
            var dados = flores.InserirFlor(new Flor()
            {
                Nome = nome,
                Quantidade = quantidade
            });
            if (dados)
            {
                Console.WriteLine("Flor cadastrada com sucesso!");
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
