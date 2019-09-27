using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasePrincipal.Model;
using BasePrincipal.Controller;

namespace SistemaDeVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            VeiculoController.Menu();
            
            ContextDB veiculos = new ContextDB();

            var template = "Id {0,3} Carro {1,30} Valor {2,6} Quantidade {3,6} Data da venda {4,15}";

            veiculos.ListaDeVeiculos.ForEach(i => 
            Console.WriteLine(string.Format(template,i.Id,i.Nome,i.Valor,i.Quantidade,i.DataDaVenda.ToShortDateString())
            //$"Id: {i.Id} Carro: {i.Nome} Valor: {i.Valor} Quantidade: {i.Quantidade} Data: {i.DataDaVenda.ToShortDateString()}"
            ));
            Console.ReadKey();
        }
    }
}
