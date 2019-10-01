using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";
            var listaDeOpcoes = conteudo.Split(';');
            Console.WriteLine("Escolha uma das opções abaixo: \r\n");
            foreach (var item in listaDeOpcoes)
            {
                var opcoes = item.Split(',');
                var nome = opcoes[0].Split(':')[1];
                Console.WriteLine(nome);
            }

            Console.WriteLine("\r\nEscolha uma das opções acima para verificar maioridade: ");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeOpcoes)
            {
                var opcoes = item.Split(',');
                var nome = opcoes[0].Split(':')[1];
                var idade = opcoes[1].Split(':')[1];
                if ((nomeBusca == nome) && (int.Parse(idade) >= 18))
                {
                    Console.WriteLine($"\r\nO {nome} é maior de idade!");
                }
                else if((nomeBusca == nome) && (int.Parse(idade) < 18))
                {
                    Console.WriteLine($"\r\nO {nome} é menor de idade!");
                }
            }
            Console.ReadKey();
        }
    }
}
