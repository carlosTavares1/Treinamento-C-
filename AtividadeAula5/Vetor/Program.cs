using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = i;
                Console.WriteLine(vetor[i]);
            }
            Console.ReadKey();
        }
    }
}
