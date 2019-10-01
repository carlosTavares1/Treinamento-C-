using QuestaoUm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaAmigos = new List<Amigos>();

            listaAmigos.Add(new Amigos()
            {
                Nome = "Carlos",
                TempoDeAmizade = 4
            });

            listaAmigos.Add(new Amigos()
            {
                Nome = "Pedro",
                TempoDeAmizade = 8
            });

            listaAmigos.Add(new Amigos()
            {
                Nome = "Marcelo",
                TempoDeAmizade = 10
            });

            listaAmigos.ForEach(i => Console.WriteLine($"O {i.Nome} tem {i.TempoDeAmizade} anos"));

            Console.ReadKey();
        }
    }
}
