using CatalogoCelulares.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;
namespace CellDu
{
    class Program
    {
        static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;

            while (opcao != 0)
            {
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir celular");
                Console.WriteLine("2 - Atualizar celular");
                Console.WriteLine("3 - Remover celular");
                Console.WriteLine("4 - Listar celular");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();
                            InserirCelular();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            AtualizarCelular();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            RemoverCelular();
                            Console.Clear();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            ListarCelular();
                        }
                        break;
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("Saindo do sistema...Pressione qualquer tecla para sair...");
                        }
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.Write("Opção inválida! Pressione qualquer tecla para retornar ao menu principal..."); ;
                            Console.ReadKey();
                        }
                        break;
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Este método recebe informações através de variáveis e atribui à base de dados via objeto da classe pessoa
        /// </summary>
        public static void InserirCelular()
        {
            Console.WriteLine("--Inserir Celular");
            Console.WriteLine("Informe a marca do celular");

            var marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo do celular");

            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o valor do aparelho");

            var preco = double.Parse(Console.ReadLine());

            var resultado = celulares.InserirCelular(new Celular()
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco
            });

            if (resultado)
            {
                Console.WriteLine("Celular cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar aparelho!");
            }
        }
        /// <summary>
        /// Este método realiza a atualização de algum elemento na base de dados com base na informação do id que desejar.
        /// </summary>
        public static void AtualizarCelular()
        {
            ListarCelular();

            Console.WriteLine("Informe o id para alteração de registro: ");
            var celularId = int.Parse(Console.ReadLine());

            var celular = celulares.GetCelulars().FirstOrDefault(x => x.Id == celularId);

            if (celular == null)
            {
                Console.WriteLine("Id informado inválido");
                return;
            }

            Console.WriteLine("Informe a marca do celular");

            celular.Marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo do celular");

            celular.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o valor do aparelho");

            celular.Preco = double.Parse(Console.ReadLine());

            var resultado = celulares.AtualizarCelular(celular);

            if (resultado)
            {
                Console.WriteLine("Celular atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao atualizar aparelho!");
            }
        }
        /// <summary>
        /// Este método realiza a inativação de um registro do nome do celular que desejar.
        /// </summary>
        public static void RemoverCelular()
        {
            ListarCelular();

            Console.WriteLine("Informe o Id para a remoção do registro: ");
            var celularId = int.Parse(Console.ReadLine());

            var resultado = celulares.RemoverCelular(celularId);

            if (resultado)
            {
                Console.WriteLine("Celular removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao remover aparelho");
            }
        }
        /// <summary>
        /// Este método exibe a lista de celulares
        /// </summary>
        public static void ListarCelular()
        {
            Console.WriteLine("--Listar Celular--\r\n");

            celulares.GetCelulars().ToList<Celular>().ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo} Preço: {x.Preco}"));
            Console.ReadKey();
            Console.Clear();
        }
    }
}
