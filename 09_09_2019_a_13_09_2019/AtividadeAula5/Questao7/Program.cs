using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            LeituraTexto();   
        }
        /// <summary>
        /// Método faz a leitura e conta o número de a, e, i, o e u
        /// </summary>
        static void LeituraTexto()
        {
            Console.WriteLine("Informe o texto: ");
            var texto = Console.ReadLine();
            int i = 0;
            var count = 0;
            while (i < texto.Length)
            {
                if (texto[i] == 'a')
                    count++;
                else if (texto[i] == 'e')
                    count++;
                else if (texto[i] == 'i')
                    count++;
                else if (texto[i] == 'o')
                    count++;
                else if (texto[i] == 'u')
                    count++;
                i++;
            }
            Console.WriteLine($"A quantidade de a, e, i, o, u é: {count}");
            Console.ReadKey();
        }
    }
}
