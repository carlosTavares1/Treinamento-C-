using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasePrincipal.Model;

namespace BasePrincipal.Controller
{
    public class VeiculoController
    {

        public static void Menu()
        {
            Console.WriteLine("----------Sistema de consulta de vendas de Veículos----------");
            Console.WriteLine("Escolha uma das opções abaixo");
            Console.WriteLine(@"1 - Relatórios do mês
2 - Vendas do mês
3 - Total de vendas mês
4 - Média das vendas no mês");
            Console.WriteLine("Digite sua opção:")
            var opcao = int.Parse(Console.ReadKey().KeyChar.ToString());
            switch (opcao)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Informe o mês para consulta:");
                        
                    }
                default:
            }
        }

        public static void ConsultaPorMes()
        {
            ContextDB consulta = new ContextDB();
            consulta.ListaDeVeiculos.FindAll(i => i.)
        }
    }
}
