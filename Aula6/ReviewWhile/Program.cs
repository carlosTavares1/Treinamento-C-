using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto: ");
            var conteudoDoTexto = Console.ReadLine();
            int i = 0;
            while(i < conteudoDoTexto.Length)
            {
                Console.WriteLine(conteudoDoTexto[i]);
                i++;
            }
            Console.ReadKey();
        }
    }
}
