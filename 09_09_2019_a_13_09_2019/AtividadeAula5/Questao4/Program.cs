using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto: ");
            string texto = Console.ReadLine();

            Console.WriteLine($"O texto informa possui {texto.Length} caracteres.");
            Console.ReadKey();
        }
    }
}
