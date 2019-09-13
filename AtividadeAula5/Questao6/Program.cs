using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto: ");
            string texto = Console.ReadLine();
            Console.WriteLine(texto.Replace("banana", "laranja"));
            Console.ReadKey();
        }
    }
}
