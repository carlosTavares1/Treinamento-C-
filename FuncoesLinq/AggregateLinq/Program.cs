using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Felipe",
                "Giomar",
                "Euricledson",
                "Adagoberto",
                "Ezebio",
                "Irineudson"
            };

            var texto = listaDeNomes.Aggregate((txt, str) => txt + ";" + str);

            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
