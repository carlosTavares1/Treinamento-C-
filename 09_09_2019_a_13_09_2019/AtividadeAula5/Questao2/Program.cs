using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            PegaNome();
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo pega o nome
        /// </summary>
        /// <returns> informa uma mensagem com o nome</returns>
        private static void PegaNome()
        {
            Console.WriteLine("                                 -----------Seja bem-vindo!----------");
            Console.WriteLine("Informe o nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Seja bem-vindo, {nome}!");
        }
    }
}
