using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosDeRepeticaoParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComSplitLista();
        }
        /// <summary>
        /// Método faz a varredura de um array e retorna os valores com exceção do a
        /// </summary>
        private static void IniciandoForeach01()
        {
            Console.WriteLine("Informar o texto: ");
            var texto = Console.ReadLine();

            foreach (var leitura in texto)
            {
                if (leitura == 'a')
                    continue;
                Console.WriteLine(leitura);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Este método realiza a busca de uma palavra digitada
        /// </summary>
        private static void ForeachComSplit()
        {
            Console.WriteLine("Informe seu nome: ");
            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção;e;vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replace";

            Console.WriteLine("Informe a palavra para realizar a busca: ");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(';');

            foreach(var item in conteudoTextoSplit)
            {
                if(palavra == item)
                {
                    Console.WriteLine("Palavra encontrada com sucesso.");
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Método que busca a idade a partir do nome
        /// </summary>
        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Carlos,idade:27;nome:Giomar,idade:75;nome:Eusebio,idade:29";

            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuários cadastrados no sistema: ");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

            Console.WriteLine("Informe o nome desejado: ");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');
                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];
                if (nome == nomeBusca)
                    Console.WriteLine($"O {nome} está com {idade} anos de idade.");
            }
            Console.ReadKey();
        }
    }
        
}
