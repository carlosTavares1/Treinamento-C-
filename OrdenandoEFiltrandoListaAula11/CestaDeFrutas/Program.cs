using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cestaDeFrutas = new List<Fruta>();
            //vamos no mercado
            //Tomate
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });
            //Goiaba
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });
            //Manga
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarelo",
                Peso = 150
            });

            cestaDeFrutas.
                //Neste ponto ordenamos os valores de forma decrescente pelo nome
                OrderByDescending(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id: {i.Id} | Nome: {i.Nome}"));

            Console.WriteLine("-------------------------------------");

            cestaDeFrutas.
                //Aqui ordenamos os valores pelo id de forma crescente
                OrderBy(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id: {i.Id} | Nome: {i.Nome}"));

            Console.WriteLine("-------------------------------------Filtro Peso");

            var filtroCesta = cestaDeFrutas.
                //Aqui filtramos os registros maiores de 100 gramas
                Where(x => x.Peso > 100).OrderBy(x => x.Nome);

            filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome} Peso {i.Peso}"));
            //frutinha recebe cada fruta da nossa cesta
            (from frutinha in cestaDeFrutas where frutinha.Nome == "Manga" select frutinha).ToList<Fruta>().ForEach(i => Console.WriteLine($"Fruta escolhida {i.Nome}"));

            Console.ReadKey();
        }
    }
}
