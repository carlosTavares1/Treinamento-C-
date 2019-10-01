using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int valor = r.Next(100);
                if (!numeros.Contains(valor))
                {
                    numeros.Add(valor);
                }
                else
                {
                    i--;
                }
                Console.WriteLine("");
            }





            //Console.WriteLine(Math.Pow(2, 3));
            //Console.WriteLine(Math.Sqrt(144));
            //int resultadoConvesao = 0;
            
            //Console.WriteLine(int.TryParse("kkk", out resultadoConvesao));
            //Console.ReadKey();
        }
    }
}
