using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDoisUsandoSplit
{
    class Program
    {
        static void Main(string[] args)
        {   
            var texto = "nome:argo,marca:fiat,ano:2015;nome:gol,marca:wolkswagen,ano:2017;nome:versa,marca:nissan,ano:2019;nome:hb20,marca:hyundai,ano:2020";

            var listaDeInformacoes = texto.Split(';');

            Console.WriteLine("Veículos cadastrados: ");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

            Console.WriteLine("Informe o veículo desejado: ");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');
                var nome = informacoesSplit[0].Split(':')[1];
                var marca = informacoesSplit[1].Split(':')[1];
                var ano = informacoesSplit[2].Split(':')[1];
                if (nomeBusca == nome)
                    Console.WriteLine($"O carro selecionado é da {marca} e de {ano}");
            }

            Console.ReadKey();
        }
    }
}
