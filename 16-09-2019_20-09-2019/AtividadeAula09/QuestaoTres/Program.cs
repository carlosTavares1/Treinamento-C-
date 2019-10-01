using QuestaoTres.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoTres
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaCarros = new List<Carro>();
            Carro carro = new Carro();

            Console.WriteLine("                                 ----------Cadastro de veículos----------");

            Console.WriteLine("Informe a marca do veículo:");
            carro.Marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo do veículo:");
            carro.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o ano do veículo:");
            carro.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do veículo:");
            carro.Valor = double.Parse(Console.ReadLine());

            listaCarros.Add(carro);

            Console.Clear();

            listaCarros.ForEach(i => Console.WriteLine($"O {i.Modelo} é um veículo da {i.Marca} de {i.Ano} no valor de {i.Valor}"));

            Console.ReadKey();
        }
    }
}
