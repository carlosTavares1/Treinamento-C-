using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        { 
            ShowInitAppText();
            string nome = string.Empty;
            int idade = 0;

            while (AskToContinue() == 1)
            {
                nome = AskToName();
                idade = AskAge(nome);
            }
            Console.WriteLine($"Suas informações: Nome {nome} Idade {idade}");
        }
        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema alone
        /// </summary>
        private static void ShowInitAppText()
        {
            Console.WriteLine("                                         -------------------");
            Console.WriteLine("                                         --Seja bem-vindo!--");
            Console.WriteLine("                                         -------------------");
        }
        /// <summary>
        /// Metodo para realizar pergunta se deseja continuar
        /// </summary>
        /// <returns>retorna o valor que foi inserido</returns>
        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? sim(1) não(2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }
        /// <summary>
        /// Método retorna informa se pode beber ou não
        /// </summary>
        private static int AskAge(string nome)
        {
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
               Console.WriteLine($"{nome} Voce pode beber!");
            else
               Console.WriteLine($"Opa!{nome} Voce não pode beber!");
            return idade;
        }
        /// <summary>
        /// Método para perguntar a idade
        /// </summary>
        /// <returns>Retorna a idade informada</returns>
        private static string AskToName()
        {
            Console.WriteLine("\r\nQual seu nome?");
            return Console.ReadLine();
        }
    }
}
