using QuestaoDois.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuestaoDois
{
    class Program
    {
        static List<Pessoa> listaPessoa = new List<Pessoa>();
        
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
        private static void Cadastrar()
        {
            Pessoa pessoa = new Pessoa();
            Console.Clear();
            Console.WriteLine("                             ----------Novo Cadastro----------");
            Console.WriteLine("\r\nInforme o nome:");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade:");
            pessoa.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe F para feminino ou M para masculino:");
            pessoa.Sexo = char.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine("\r\nInforme a altura:");
            pessoa.Altura = double.Parse(Console.ReadLine());
            listaPessoa.Add(pessoa);
            Console.Clear();
            Console.WriteLine("\r\n                         ----------Cadastro Realizado com sucesso!----------");
            Console.WriteLine("\r\nPressione qualquer tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        private static void Listar()
        {
            Console.Clear();
            Console.WriteLine("Nome                      |      Idade    |    Sexo   |    Altura");
            listaPessoa.ForEach(i => Console.WriteLine($"{i.Nome}                      |        {i.Idade}     |      {i.Sexo}    |    {i.Altura}"));
            Console.WriteLine("\r\nPressione qualquer tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        private static void Menu()
        {
            Console.WriteLine("                             ----------Seja bem-vindo----------");
            Console.WriteLine("                         ------------Sistema de cadastro------------");
            Console.WriteLine("Seleciona uma das opções abaixo");
            Console.WriteLine("\r\n1 - Realizar novo cadastro \r\n2 - Exibir lista de cadastro \r\n3 - Sair do sistema \r\n4 - Retornar ao menu");
            var opcao = int.Parse(Console.ReadKey().KeyChar.ToString());
            switch (opcao)
            {
                case 1:
                    {
                        Cadastrar();
                    }
                    break;
                case 2:
                    {
                        Listar();
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("\r\nSaindo do sistema...Pressione qualquer tecla");
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        Menu();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
