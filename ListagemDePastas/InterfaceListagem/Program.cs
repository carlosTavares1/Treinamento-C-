using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace InterfaceListagem
{
    class Program
    {
        static DocumentsAutoGenerate d = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {
            var menu = int.MinValue;

            while(menu != 0)
            {
                Console.Clear();
                Console.WriteLine("Sistema de pasta");
                Console.WriteLine("1 - Criar Pasta em meus documentos");
                Console.WriteLine("2 - Deletar pasta");
                Console.WriteLine("3 - Exibir pasta");
                Console.WriteLine("4 - Bonus sextooooooou");
                Console.WriteLine("0 - sair");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o nome da pasta:");
                            var nomeDaPasta = Console.ReadLine();
                            d.CriarPastaMeusDocumentos(nomeDaPasta);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Informe o nome da pasta que deseja apagar:");
                            var nomeDaPasta2 = Console.ReadLine();
                            d.DeletarPastaMeusDocumentos(nomeDaPasta2, true);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Pasta");
                            d.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x));
                            Console.ReadKey();
                        }
                        break;
                    default:
                        break;
                }
            }
            
            Console.ReadKey();
        }
    }
}
