using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BicicletaLibrary.Controller;
using BicicletaLibrary.Model;
using Newtonsoft.Json;

namespace InterfaceSistema
{
    public class Program
    {
        static ControleBicicleta bicicleta = new ControleBicicleta();
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("==========Sistema de Cadastro de Bicicletas=========");
            Console.WriteLine("Escolha uma das opções abaixo: ");
            Console.WriteLine("1 - Listar bicicleta");
            Console.WriteLine("2 - Inserir bicicleta");
            Console.WriteLine("3 - Remover bicicleta");
            Console.WriteLine("4 - Atualizar bicicleta");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite a opção desejada: ");
            var opcao = int.MinValue;
            while (opcao != 0)
            {
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        {
                            MostrarBicicleta();
                            Menu();
                        }
                        break;
                    case 2:
                        {
                            InserirBicicleta();
                            Menu();
                        }
                        break;
                    case 3:
                        {
                            RemoverBicicleta();
                            Menu();
                        }
                        break;
                    case 4:
                        {
                            AtualizarBicicleta();
                            Menu();
                        }
                        break;
                    case 0:
                        {
                            Console.WriteLine("Saindo do sistema...Pressione qualquer tecla para sair...");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                        break;
                }
            }
        }

        private static void MostrarBicicleta()
        {
            Console.Clear();
            var listaBicicleta = bicicleta.GetBicicletas().OrderByDescending(x => x.Valor).ToList<Bicicleta>();
            listaBicicleta.ForEach(x => Console.WriteLine($"Marca: {x.Marca} Modelo: {x.Modelo} Valor: {x.Valor}"));
            string jsonLista = JsonConvert.SerializeObject(listaBicicleta);
            string caminho = ("C:\\Users\\900070\\source\\repos\\carlosTavares1\\Treinamento-C-\\SistemaCadastroDeBicicletas\\Json\\listaJson.txt");
            File.WriteAllText(caminho, jsonLista);
            Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }

        private static void InserirBicicleta()
        {
            Console.Clear();
            Console.WriteLine("=========Inserção==========");
            Console.Write("Informe a marca: ");
            var marca = Console.ReadLine();
            Console.Write("Informe o modelo: ");
            var modelo = Console.ReadLine();
            Console.Write("Informe o valor: ");
            var valor = double.Parse(Console.ReadLine());
            var insercao = bicicleta.InserirBicicleta(new Bicicleta()
            {
                Marca = marca,
                Modelo = modelo,
                Valor = valor
            });
            if (insercao)
            {
                Console.WriteLine("Cadastro realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar!");
            }
            Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }

        private static void RemoverBicicleta()
        {
            Console.Clear();
            Console.WriteLine("==========Remoção==========");
            bicicleta.GetBicicletas().OrderByDescending(x => x.Valor).ToList<Bicicleta>().ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo} Valor: {x.Valor}"));
            Console.Write("Após ter escolhido sua opção, pressione qualquer tecla para prosseguir...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("==========Remoção==========");
            Console.WriteLine("Informe o Id do registro que voce deseja remover: ");
            var remocao = int.Parse(Console.ReadLine());
            var remocaoId = bicicleta.RemoverBicicleta(new Bicicleta()
            {
                Id = remocao
            });
            if (remocaoId)
            {
                Console.WriteLine("Registro deletado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao deletar o registro!");
            }
            Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }

        private static void AtualizarBicicleta()
        {
            Console.Clear();
            Console.WriteLine("==========Alteração==========");
            bicicleta.GetBicicletas().OrderByDescending(x => x.Valor).ToList<Bicicleta>().ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo} Valor: {x.Valor}"));
            Console.Write("Após ter escolhido sua opção, pressione qualquer tecla para prosseguir...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("==========Alteração==========");
            Console.WriteLine("Informe o id para realizar a alteração:");
            var alteracao = int.Parse(Console.ReadLine());
            var listaAlteracao = bicicleta.GetBicicletas().FirstOrDefault(x => x.Id == alteracao);
            Console.Write("Informe uma nova marca: ");
            listaAlteracao.Marca = Console.ReadLine();
            Console.Write("Informe um novo modelo: ");
            listaAlteracao.Modelo = Console.ReadLine();
            Console.Write("Informe um novo valor: ");
            listaAlteracao.Valor = double.Parse(Console.ReadLine());
            var resultado = bicicleta.AlterarBicicleta(listaAlteracao);
            if (resultado)
            {
                Console.WriteLine("Alteração realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao alterar!");
            }
            Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }
    }
}
