using ExercicioAula11.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula11
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPessoas = new List<Pessoa>();
            #region ListaDePessoas
            listaPessoas.Add(new Pessoa()
            {
                Id = 1,
                Nome = "Spears",
                DataNascimento = DateTime.Parse("07/11/2004"),
                Carteira = 846.96
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 2,
                Nome = "Swanson",
                DataNascimento = DateTime.Parse("20/06/2003"),
                Carteira = 233.09
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 3,
                Nome = "Gay",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 911.92
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 4,
                Nome = "Gregory",
                DataNascimento = DateTime.Parse("02/01/2000"),
                Carteira = 469.01
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 5,
                Nome = "Olson",
                DataNascimento = DateTime.Parse("18/07/2001"),
                Carteira = 261.90
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 6,
                Nome = "Garza",
                DataNascimento = DateTime.Parse("01/04/2000"),
                Carteira = 360.41
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 7,
                Nome = "Sweet",
                DataNascimento = DateTime.Parse("12/03/2003"),
                Carteira = 312.76
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 8,
                Nome = "Cline",
                DataNascimento = DateTime.Parse("26/03/2002"),
                Carteira = 484.51
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 9,
                Nome = "Oliver",
                DataNascimento = DateTime.Parse("05/07/2004"),
                Carteira = 513.76
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 10,
                Nome = "Vang",
                DataNascimento = DateTime.Parse("10/07/2000"),
                Carteira = 271.05
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 11,
                Nome = "Maddox",
                DataNascimento = DateTime.Parse("29/05/2004"),
                Carteira = 783.97
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 12,
                Nome = "Garrett",
                DataNascimento = DateTime.Parse("03/06/2006"),
                Carteira = 154.11
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 13,
                Nome = "Mcintosh",
                DataNascimento = DateTime.Parse("06/07/2006"),
                Carteira = 902.80
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 14,
                Nome = "Yang",
                DataNascimento = DateTime.Parse("29/04/2005"),
                Carteira = 550.48
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 15,
                Nome = "Hendricks",
                DataNascimento = DateTime.Parse("05/09/2003"),
                Carteira = 410.56
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 16,
                Nome = "Cain",
                DataNascimento = DateTime.Parse("12/01/2002"),
                Carteira = 221.13
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 17,
                Nome = "Blackburn",
                DataNascimento = DateTime.Parse("10/05/2000"),
                Carteira = 135.67
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 18,
                Nome = "Howe",
                DataNascimento = DateTime.Parse("27/09/2005"),
                Carteira = 360.14
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 19,
                Nome = "Pratt",
                DataNascimento = DateTime.Parse("27/09/2001"),
                Carteira = 991.83
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 20,
                Nome = "Sherman",
                DataNascimento = DateTime.Parse("20/02/2003"),
                Carteira = 667.00
            });
            #endregion
            Console.WriteLine("----------Lista crescente por nome----------\r\n");
            listaPessoas.OrderBy(x => x.Nome).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome}"));
            Console.WriteLine("\r\n----------Lista descrescente por data de nascimento----------\r\n");
            listaPessoas.OrderByDescending(x => x.DataNascimento).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Nome {i.Nome} Nascimento {i.DataNascimento.ToShortDateString()}"));
            Console.WriteLine("\r\n----------Lista de pessoas que têm mais de 500 reais na carteira----------\r\n");
            var listaPorValor = listaPessoas.Where(x => x.Carteira > 500).OrderBy(x => x.Carteira);
            listaPorValor.ToList<Pessoa>().ForEach(i => Console.WriteLine($"Nome {i.Nome} Valor {i.Carteira}"));
            Console.WriteLine("\r\n----------Lista de pessoas maiores que 18 anos----------\r\n");
            var listaDezoito = listaPessoas.FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) >= 18).OrderBy(x => x.DataNascimento).ToList<Pessoa>();
            listaDezoito.ForEach(i => Console.WriteLine($"Nome {i.Nome}         Nascimento {i.DataNascimento.ToShortDateString()}"));
            Console.WriteLine("\r\n----------Lista de pessoas menores que 16 anos----------\r\n");
            listaPessoas.FindAll(i => (DateTime.Now.Year - i.DataNascimento.Year) <= 16).OrderBy(x => x.DataNascimento).ToList<Pessoa>().ForEach(x => Console.WriteLine($"Nome {x.Nome}         Nascimento {x.DataNascimento.ToShortDateString()}"));
            Console.WriteLine("\r\n----------Lista organizada em ordem crescente por Id----------\r\n");
            listaPessoas.OrderBy(x => x.Id).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome}"));
            Console.WriteLine("\r\n----------Lista organizada em ordem decrescente por Id----------\r\n");
            listaPessoas.OrderByDescending(x => x.Id).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome}"));
            Console.ReadKey();
        }
    }
}
