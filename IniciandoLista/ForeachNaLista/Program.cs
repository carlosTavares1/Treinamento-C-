using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeDecimais();
            Console.ReadKey();
        }
        /// <summary>
        /// Este método mostra a lista de nomes
        /// </summary>
        private static void ListaString()
        {
            var minhaLista = new List<string>();
            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");
            minhaLista.ForEach(i => Console.WriteLine(i));
        }
        /// <summary>
        /// Esta método escreve as datas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();
            minhaLista.Add(new DateTime(2019, 09, 17));
            minhaLista.Add(new DateTime(2019, 09, 18));
            minhaLista.Add(new DateTime(2019, 09, 19));
            minhaLista.Add(new DateTime(2019, 09, 20));
            minhaLista.Add(new DateTime(2019, 09, 21));
            minhaLista.ForEach(i => Console.WriteLine(i.ToLongDateString()));
        }
        /// <summary>
        /// Este método lista números inteiros
        /// </summary>
        private static void ListaInt()
        {
            var minhaLista = new List<int>();
            minhaLista.Add(17);
            minhaLista.Add(18);
            minhaLista.Add(19);
            minhaLista.Add(20);
            minhaLista.ForEach(i => Console.WriteLine(i));
        }
        /// <summary>
        /// Este método escreve os valores decimais na tela
        /// </summary>
        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();
            minhaLista.Add(3.55);
            minhaLista.Add(4.88);
            minhaLista.Add(8.57);
            minhaLista.Add(9.37);
            minhaLista.ForEach(i => Console.WriteLine(i.ToString("C2") + " " + FormataNumeroDecimalEmEuro(i) + " " + FormataNumeroDecimalEmYen(i) + " " + FormataNumeroDecimalEmBitcoin(i))); 
        }
        /// <summary>
        /// Este método converte os número decimal em dolar
        /// </summary>
        /// <param name="numero">Número real</param>
        /// <returns>Retorna o número convertido</returns>
        private static string FormataNumeroDecimalEmDolar(double numero)
        {
            var conversor = numero / 4.09;
            return conversor.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
        /// <summary>
        /// Este método converte o número decimal em euro
        /// </summary>
        /// <param name="numero">Número real</param>
        /// <returns>Retorna o valor convertido</returns>
        private static string FormataNumeroDecimalEmEuro(double numero)
        {
            var conversor = numero / 4.52;
            return conversor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$","EURO ");
        }
        /// <summary>
        /// Este método converte o decimal em euro
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private static string FormataNumeroDecimalEmYen(double numero)
        {
            var conversor = numero / 0.038;
            return conversor.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        /// <summary>
        /// Este método converte o decimal em bitcoin
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private static string FormataNumeroDecimalEmBitcoin(double numero)
        {
            var conversor = numero / 41742;
            return conversor.ToString("C10", CultureInfo.CreateSpecificCulture("en-US")).Replace("$","BTC ");
        }
    }
}
