using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutaAtvidade7
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaDoQuadrado();
            Console.ReadKey();
        }
        private static void AreaDoQuadrado()
        {
            Console.WriteLine("                 -----Seja bem-vindo!-----");
            Console.WriteLine("               Cálculo da área do quadrado ");
            Console.WriteLine("Informe o lado do quadrado em metros:");
            var lado = double.Parse(Console.ReadLine());
            var area = lado * lado;
            Console.WriteLine($"A área do quadrado é: {area} m²");
            
        }
    }
}
