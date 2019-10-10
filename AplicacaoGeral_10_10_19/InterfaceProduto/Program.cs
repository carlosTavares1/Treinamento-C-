using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Controller;
using Estoque.Model;

namespace InterfaceProduto
{
    class Program
    {
        static ProductController produto = new ProductController();
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
        /// <summary>
        /// Este método exibe o menu e gerencia os demais métodos
        /// </summary>
        private static void Menu()
        {
            Console.WriteLine("         ==========Sistema de Cadastro de Produtos==========");
            Console.WriteLine("Escolha uma das opções abaixo: ");
            Console.WriteLine("1 - Inserir novo produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Digite a opção escolhida:");
            var opcao = int.MinValue;
            while (opcao != 0)
            {
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        {
                            InserirNovoProduto();
                            Console.Clear();
                            Menu();
                        }
                        break;
                    case 2:
                        {
                            MostrarProdutos();
                            Console.Clear();
                            Menu();
                        }
                        break;
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("Saindo do sistema...");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// Este método possui a estrutura para inserir novos registros de produto na base de dados
        /// </summary>
        private static void InserirNovoProduto()
        {
            Console.Clear();
            Console.WriteLine("=====Inserção de novo produto=====");
            Console.WriteLine("Informe o nome do produto: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe o valor do produto: ");
            var valor = double.Parse(Console.ReadLine());

            var novoCadastro = produto.InserirProduto(new Produto()
            {
                Nome = nome,
                Valor = valor
            });
            if (novoCadastro)
            {
                Console.WriteLine("Produto cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar!");
            }
            Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }
        /// <summary>
        /// Este método possui a função de mostrar os registros existentes na base de dados
        /// </summary>
        private static void MostrarProdutos()
        {
            Console.Clear();
            produto.GetProdutos().ToList<Produto>().ForEach(x => Console.WriteLine($"Id: {x.Id} Nome: {x.Nome} Valor: {x.Valor}"));
            Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }
    }
}
