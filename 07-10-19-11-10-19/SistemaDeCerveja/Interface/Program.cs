using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;
namespace Interface
{
    class Program
    {
        static CervejaController listaDeCerveja = new CervejaController();
        static Cerveja itemDaLista = new Cerveja();
        static void Main(string[] args)
        {
            MostrarMenu();

            Console.ReadKey();
        }
        private static void AdicionaNovoItem()
        {
            Console.Clear();
            Console.WriteLine("===============Módulo para adicionar novo item===============");
            Console.WriteLine("Informe o id do produto:");
            itemDaLista.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do produto:");
            itemDaLista.Nome = Console.ReadLine();
            Console.WriteLine("Informe o volume em litros:");
            itemDaLista.Litros = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o percentual de alcool em %:");
            itemDaLista.Alcool = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do produto por unidade:");
            itemDaLista.Valor = double.Parse(Console.ReadLine());
            Console.Clear();
            listaDeCerveja.SetCervejaContext(itemDaLista);
            Console.WriteLine("===============Cadastro Realizado com Sucesso===============");
            Console.Write("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
            MostrarMenu();
        }

        private static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("===============Bem-vindo ao sistema de cerveja===============");
            Console.WriteLine("Escolha uma das opções abaixo...");
            Console.WriteLine(@"1 - Listar produtos
2 - Adicionar novo item a lista
3 - Valor total
4 - Valor total em litros
5 - Verificar alcolemia
0 - Sair do sistema");
            Console.WriteLine("Informe a opção escolhida:");
            var opcao = int.MinValue;
            while (opcao != 0)
            {
                opcao = int.Parse(Console.ReadKey().KeyChar.ToString());
                switch (opcao)
                {
                    case 1:
                        {
                            ListarProdutos();
                        }
                        break;
                    case 2:
                        {
                            AdicionaNovoItem();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("==========Valores==========");
                            Console.Write("O valor total em cerveja é ");
                            Console.WriteLine(listaDeCerveja.SumValorCervejaContext());
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("==========Valores==========");
                            Console.Write("O valor total em cerveja é ");
                            Console.WriteLine(listaDeCerveja.SumValorCervejaContext());
                        }
                        break;
                    case 5:
                        {

                            if (VerificarAlcolemia() > 0.6)
                            {
                                Console.WriteLine("Será preso!");
                            }
                            else
                            {
                                Console.WriteLine("Não será preso!");
                            }
                        }
                        break;
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("Saindo do sistema...Digite zero para sair");
                        }
                        break;
                    default:
                        break;
                }
            }
            
        }

        private static void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("===============Lista de Produtos Cadastrados===============\r\n");
            listaDeCerveja.GetCervejaContext().ForEach(i => Console.WriteLine(string.Format("Id: {0,3} Nome: {1,12} Litros: {2,7} Alcool(%): {3,7} Valor: {4,7}", i.Id, i.Nome,i.Litros,i.Alcool,i.Valor)));
            Console.Write("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
            Console.Clear();
            MostrarMenu();
        }

        private static double VerificarAlcolemia()
        {
            Console.Clear();
            Console.WriteLine("==========Cálculo de Alcolemia==========");
            Console.WriteLine("Informe o peso:");
            var peso = double.Parse(Console.ReadLine());
            Console.WriteLine("É homem ou mulher?");
            var sexo = Console.ReadLine();
            Console.WriteLine("Está em jejum?");
            var jejum = Console.ReadLine();
            if(sexo == "homem" && jejum == "sim")
            {
                var calculo = listaDeCerveja.SumLitrosCervejaContext()/(peso/0.7);
                return calculo;

            }
            else if(sexo == "mulher" && jejum == "sim")
            {
                var calculo = listaDeCerveja.SumLitrosCervejaContext() / (peso / 0.6);
                return calculo;
            }
            else
            {
                var calculo = listaDeCerveja.SumLitrosCervejaContext() / (peso / 1.1);
                return calculo;
            }
        }
    }
}