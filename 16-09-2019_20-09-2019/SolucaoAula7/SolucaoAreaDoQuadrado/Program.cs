using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace SolucaoAreaDoQuadrado
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            MenuSistema();
            Console.ReadKey();
        }

        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opções do menu: ");
            Console.WriteLine("1 - Calculo de área");
            Console.WriteLine("2 = Mostrar animação");
            Console.WriteLine("3 - Mostrar lista de cerveja");
            Console.WriteLine("4 - Mostrar lista de veículos");
            Console.WriteLine("5 - Sair do sistema");

            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    {
                        CalculaArea();
                        MenuSistema();
                    }
                    break;
                case 2:
                    {
                        var anima = new AnimacoesEmFrames();
                        anima.Desenhe();
                        MenuSistema();
                    }
                    break;
                case 3:
                    {
                        MostrarLista.nameCerveja();
                        MenuSistema();
                    }
                    break;
                case 4:
                    {
                        showVeiculos(ListaCarro.listaVeiculos());
                        MenuSistema();
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Saindo......");
                        Console.ReadKey();
                        return;
                    }
                default:
                    break;
            }
        }

        private static void showVeiculos(List<string> marcaVeiculo)
        {
            foreach (var item in marcaVeiculo)
            {
                Console.WriteLine(item);
            }
        }

        public static void AreaDoQuadrado()
        {
            CalculaArea();
        }
        public static void CalculaArea()
        {
            Console.WriteLine("Informe o lado do quadrado: ");
            var ladoQuadrado = int.Parse(Console.ReadLine());

            var biblioteca = new CalculoDeArea();

            Console.WriteLine($"Minha área é {biblioteca.CalculaAreaDoQuadrado(ladoQuadrado)}");
            Console.ReadKey();
        }
    }
}
