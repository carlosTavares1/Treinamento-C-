using MinhaSegundaClasse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSegundaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaCestaDeFrutas = new List<Frutas>();

            minhaCestaDeFrutas.Add(new Frutas()
            {
                nome = "Banana",
                quantidade = 15
            });

            minhaCestaDeFrutas.Add(new Frutas()
            {
                nome = "Maçã",
                quantidade = 8
            });

            minhaCestaDeFrutas.Add(new Frutas()
            {
                nome = "Jaca",
                quantidade = 7
            });
            minhaCestaDeFrutas.ForEach(i => Console.WriteLine($"Nome:{i.nome} Quantidade:{i.quantidade}"));
            Console.ReadKey();
        }
    }
}
