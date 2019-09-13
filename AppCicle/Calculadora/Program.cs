using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int soma = 0;
            Console.WriteLine("Calculadora de soma");
            Console.WriteLine("Informe um valor: ");
            numero = int.Parse(Console.ReadKey().KeyChar.ToString());

            for(int i =0; i < 10; i++)
            {
                soma = numero + i;
                Console.WriteLine($"A soma dos valores é {numero} + {i} = {soma}");
            }
            Console.ReadKey();
        }
    }
}
