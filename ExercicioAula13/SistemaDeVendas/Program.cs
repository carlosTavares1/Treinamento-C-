using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasePrincipal.Controller;

namespace SistemaDeVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            VeiculoController veiculos = new VeiculoController();

            veiculos.ListaDeVeiculos.ForEach(i => Console.WriteLine());
        }
    }
}
