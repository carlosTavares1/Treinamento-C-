using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            SolicitaDados();
            Console.ReadKey();
        }
        /// <summary>
        /// Método para solicitar dados do sistema
        /// </summary>
        static void SolicitaDados()
        {
            Console.WriteLine("                                     ----------Seja bem-vindo!----------");   
            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
                Console.WriteLine($"Parabéns, {nome} , voce já está na fase adulta!");
            else
                Console.WriteLine($"Calma, {nome} , tudo ao seu tempo logo voce terá 18 anos de idade!");
        }
    }
}
