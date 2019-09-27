using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Controller;
using SistemaRelatorioCarros.Model;

namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        {
            Console.WriteLine("Informações das vendas realizadas durante o ano de 2019:");
            vendasController.GetVendas().ForEach(i => imprimeInformacoes(i));

            MostraMenuRelatorio();

            Console.ReadKey();
        }

        public static void imprimeInformacoes(Venda venda)
        {
            Console.WriteLine(string.Format("Id {0,3} Carro {1,8}", venda.Id, venda.Carro));
        }

        private static void MostraMenuRelatorio()
        {
            Console.Clear();
            Console.WriteLine("Menu de relatórios");
            Console.WriteLine("1 - Menu por período mensal");

            var menuEscolhido = int.MinValue;
            while(menuEscolhido != 0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());
                switch (menuEscolhido)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o mês para realizar o filtro");
                            var mesEscolhido = int.Parse(Console.ReadLine());

                            var listaDoPerido = vendasController.GetVendas(mesEscolhido);

                            listaDoPerido.ForEach(i => imprimeInformacoes(i));

                            var totalMes = listaDoPerido.Sum(x => x.Valor * x.Quantidade);

                            var mediaPerido = listaDoPerido.Average(x => (x.Valor * x.Quantidade));

                            Console.WriteLine($"Total do mês {mesEscolhido} é {totalMes.ToString("C")}");

                            Console.WriteLine($"Média do mês {mesEscolhido} é {mediaPerido.ToString("C")}");

                            Console.ReadKey();
                        }
                        break;
                    case 0:
                        {
                            Console.ReadKey();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
