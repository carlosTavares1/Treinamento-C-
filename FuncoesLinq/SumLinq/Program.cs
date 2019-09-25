using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarInteiroLista();
            SomarInteiroPrimitivos();
            SomaBalasListaDeCriancas();
            Console.ReadKey();
        }
        /// <summary>
        /// Este método realiza a soma de todas as posições do vetor
        /// </summary>
        private static void SomarInteiroPrimitivos()
        {
            //quando utilizamos [] em um tipo primitivo podemos criar uma coleção destes valores
            int[] colecaoDeInteiros = new int[5] { 1, 2, 3, 4, 5 };
            //aqui somamos o valor de todas as posições do vetor
            Console.WriteLine(colecaoDeInteiros.Sum());
        }
        /// <summary>
        /// Este método realiza a soma de todos os valores na lista e apresenta o resultado
        /// </summary>
        private static void SomarInteiroLista()
        {
            List<int> somarLista = new List<int>() {1,2,3,4,5 };
            Console.WriteLine(somarLista.Sum());
        }
        /// <summary>
        /// Este método faz a soma das balas da classe criança através de uma expressão lâmbida
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            List<Crianca> crianca = new List<Crianca>()
            {
                new Crianca()
                {
                    Nome = "Joazinho",
                    Balas = 9
                },

                new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                }
            };
            Console.WriteLine(crianca.Sum(x => x.Balas));
        }
    }
}
