using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProcessoConvercao();
            Console.ReadKey();
        }
        /// <summary>
        /// Método que converte 
        /// </summary>
        /// <param name="minhaMoeda">Moeda em valor real</param>
        /// <param name="moedaAlvo">Alvo em que a moeda será convertida</param>
        public static void ConvertMoeda(double minhaMoeda,string moedaAlvo)
        { 
            switch (moedaAlvo)
            {
                case "DOLAR":
                        Console.WriteLine(FormataNumeroDecimalEmDolar(minhaMoeda));
                    break;
                case "EURO":
                        Console.WriteLine(FormataNumeroDecimalEmEuro(minhaMoeda));
                    break;
                case "YEN":
                        Console.WriteLine(FormataNumeroDecimalEmYen(minhaMoeda));
                    break;
                case "BTC":
                        Console.WriteLine(FormataNumeroDecimalEmBitcoin(minhaMoeda));
                    break;
                default:
                        Console.WriteLine("Valor inválido! Digite qualquer tecla para começar novamente");
                        Console.ReadKey();
                        Console.Clear();
                        ProcessoConvercao();
                    break;
            }
        }
        /// <summary>
        /// Este método mostra os campos necessários para entrada de dados
        /// </summary>
        public static void ConversorMonetarioSis()
        {
            Console.WriteLine("Informe o valor: ");
            var meuValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tipo para converter: ");
            Console.WriteLine("EURO,DOLAR,YEN,BTC");
            var meuAlvo = Console.ReadLine().ToUpper();
            MetodosPublicos.Program.ConvertMoeda(meuValor, meuAlvo);
            Console.ReadKey();
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
            return conversor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "EURO ");
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
            return conversor.ToString("C10", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC ");
        }
        /// <summary>
        /// Este método realiza a leitura das informações de entrada
        /// </summary>
        private static void ProcessoConvercao()
        {
            Console.WriteLine("                     ---Sistema conversor de moedas cabuloso--- ");
            Console.WriteLine("informe um valor a ser convertido: ");
            var valorASerConvertido = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe uma moeda para a conversão: ");
            Console.WriteLine("DOLAR, EURO, YEN, BTC");
            var moedaAlvoParaConverter = Console.ReadLine().ToUpper();
            ConvertMoeda(valorASerConvertido, moedaAlvoParaConverter);
            Console.ReadKey();
        }
    }
}
