using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace ApresentandoOsAlcolatras
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            cervejaController.AdicionaNovaCerveja(new Cerveja()
            {
                Id = 6,
                Nome = "Giomar",
                Litros = 0.600,
                Alcool = 8,
                Valor = 0.98
            });
            cervejaController.MostraListaCerveja().ForEach(x => Console.WriteLine($"{x.Id} {x.Nome} {x.Litros} {x.Alcool} {x.Valor}"));
            Console.WriteLine("Total litros " + cervejaController.RetornaSomaListaLitros());
            Console.WriteLine("Total do valor " + cervejaController.RetornaSomaListaValor().ToString("C"));
            Console.ReadKey();
        }
    }
}
