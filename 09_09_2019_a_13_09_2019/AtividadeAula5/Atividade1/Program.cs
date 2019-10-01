using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                      ----------Sejam bem-vindos----------");
            Console.WriteLine("Informe a senha para acessar o texto: ");
            string senha = Console.ReadLine();
            
            while (senha != "casa")
            {
                senha = Console.ReadLine();
               
            }
            Console.WriteLine("Voce acertou a senha do sistema. Parabéns!");
            Console.ReadKey();
        }
    }
}
