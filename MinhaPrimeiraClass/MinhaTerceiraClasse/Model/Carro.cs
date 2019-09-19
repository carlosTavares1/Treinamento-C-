using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaTerceiraClasse.Model
{
    class Carro
    {
        /// <summary>
        /// Esta propriedade guarda o nome de um carro
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Esta propriedade armazena o nome da fabricante de um carro
        /// </summary>
        public string Marca { get; set; }
        /// <summary>
        /// Esta propriedade armazena o ano de um veículo
        /// </summary>
        public int Ano { get; set; }

        /// <summary>
        /// Este método realiza o cadastro de novos veículos no sistema
        /// </summary>
        public void Cadastrar()
        {
            var carro = new List<Carro>();
            Carro c = new Carro();
            Console.WriteLine("Informe o nome do carro:");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Informe a marca do carro:");
            c.Marca = Console.ReadLine();
            Console.WriteLine("Informe o ano do carro:");
            c.Ano = int.Parse(Console.ReadLine());
            carro.Add(c);
            Console.WriteLine("                 **********Cadastro realizado com sucesso!**********");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Menu();

        }

        public void Menu()
        {
            Console.WriteLine("                 ----------Seja bem-vindo ao sistema de cadastro de veículos----------");
            Console.WriteLine("Escolha uma das opções abaixo!\r\n");
            Console.WriteLine(@"1 - Cadastrar um novo veículo;
2 - Visualisar registros;
3 - Sair.");
            Console.WriteLine("\r\nInforme a opcão desejada:");
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
                        Console.WriteLine("                 ----------Veículos Cadastrados----------");
                        Console.WriteLine($@"");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
