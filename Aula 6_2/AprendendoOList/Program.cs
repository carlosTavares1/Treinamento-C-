using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoOList
{
    class Program
    {
        static List<string> minhaListaPulgmatica = new List<string>()
            {
                "Felipe",
                "Irineu",
                "Serilop",
                "Joao"
            };
        static List<string> listaAdicionados = new List<string>();
        static void Main(string[] args)
        {
            AdicionarItensALista();
            ListaInformacoes();
            Console.ReadKey();
        }
        /// <summary>
        /// Este método adiciona novos itens a lista
        /// </summary>
        private static void AdicionarItensALista()
        {
            Console.Clear();
            Console.WriteLine("Informe um novo item da lista: ");
            minhaListaPulgmatica.Add(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Deseja adicionar mais nomes? sim(s) não(n)");
            if (Console.ReadKey().KeyChar.ToString() == "s")
                AdicionarItensALista();
        }
        /// <summary>
        /// Este método imprimi os valores da lista
        /// </summary>
        private static void ListaInformacoes()
        {
            Console.Clear();
            Console.WriteLine("Nome adicionados a lista");
            foreach (var item in minhaListaPulgmatica)
                Console.WriteLine($"Nome: {item} foi adicionado a lista!");
        }
    }
}
