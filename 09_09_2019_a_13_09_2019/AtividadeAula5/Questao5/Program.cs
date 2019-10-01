using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma palavra: ");
            string palavra = Console.ReadLine();
            Console.WriteLine($"A primeira letra é {palavra[0]}");
            Console.WriteLine($"A última letra é {palavra[palavra.Length - 1]}");
            Console.ReadKey();
        }
    }
}