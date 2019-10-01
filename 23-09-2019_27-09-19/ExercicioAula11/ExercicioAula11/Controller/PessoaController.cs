﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioAula11.Model;
namespace ExercicioAula11.Controller
{
    class PessoaController
    {
        private List<Pessoa> ListaDePessoas { get; set; }
        /// <summary>
        /// O metodo construtor ajuda a iniciar a nossa classe para utilizarmos de maneira correta as informações 
        /// internas, com isso podemos iniciar nossa lista de pessoas sem depender do usuario ou programdor na parte interface
        /// </summary>
        public PessoaController()
        {
            ListaDePessoas = new List<Pessoa>();

            ListaDePessoas.Add(new Pessoa()
            {
                Id = 1,
                Nome = "Spears",
                DataNascimento = DateTime.Parse("07/11/2004"),
                Carteira = 846.96
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 2,
                Nome = "Swanson",
                DataNascimento = DateTime.Parse("20/06/2003"),
                Carteira = 233.09
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 3,
                Nome = "Gay",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 911.92
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 4,
                Nome = "Gregory",
                DataNascimento = DateTime.Parse("02/01/2000"),
                Carteira = 469.01
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 5,
                Nome = "Olson",
                DataNascimento = DateTime.Parse("18/07/2001"),
                Carteira = 261.90
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 6,
                Nome = "Garza",
                DataNascimento = DateTime.Parse("01/04/2000"),
                Carteira = 360.41
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 7,
                Nome = "Sweet",
                DataNascimento = DateTime.Parse("12/03/2003"),
                Carteira = 312.76
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 8,
                Nome = "Cline",
                DataNascimento = DateTime.Parse("26/03/2002"),
                Carteira = 484.51
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 9,
                Nome = "Oliver",
                DataNascimento = DateTime.Parse("05/07/2004"),
                Carteira = 513.76
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 10,
                Nome = "Vang",
                DataNascimento = DateTime.Parse("10/07/2000"),
                Carteira = 271.05
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 11,
                Nome = "Maddox",
                DataNascimento = DateTime.Parse("29/05/2004"),
                Carteira = 783.97
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 12,
                Nome = "Garrett",
                DataNascimento = DateTime.Parse("03/06/2006"),
                Carteira = 154.11
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 13,
                Nome = "Mcintosh",
                DataNascimento = DateTime.Parse("06/07/2006"),
                Carteira = 902.80
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 14,
                Nome = "Yang",
                DataNascimento = DateTime.Parse("29/04/2005"),
                Carteira = 550.48
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 15,
                Nome = "Hendricks",
                DataNascimento = DateTime.Parse("05/09/2003"),
                Carteira = 410.56
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 16,
                Nome = "Cain",
                DataNascimento = DateTime.Parse("12/01/2002"),
                Carteira = 221.13
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 17,
                Nome = "Blackburn",
                DataNascimento = DateTime.Parse("10/05/2000"),
                Carteira = 135.67
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 18,
                Nome = "Howe",
                DataNascimento = DateTime.Parse("27/09/2005"),
                Carteira = 360.14
            });
            ListaDePessoas.Add(new Pessoa()
            {
                Id = 19,
                Nome = "Pratt",
                DataNascimento = DateTime.Parse("27/09/2001"),
                Carteira = 991.83
            });
            ListaDePessoas.Add(new Pessoa
            {
                Id = 20,
                Nome = "Sherman",
                DataNascimento = DateTime.Parse("20/02/2003"),
                Carteira = 667.00
            });
        }
        public List<Pessoa> ListaDePessoaPublica
        {
            get{ return ListaDePessoas; }
        }
        /// <summary>
        /// Metodo que retorna lista de pessoas ordenada de forma asc pelo nome de cada uma
        /// </summary>
        /// <returns>Retornamos o valor já ordenado de nossa lista</returns>
        public List<Pessoa> GetPessoasOrdenadasAsc()
        {
            return ListaDePessoas.OrderBy(x => x.Nome).ToList<Pessoa>();
        }
        /// <summary>
        /// Metodo public que retorna a lista ordenada pela data de nasimento da maior data para a menor data
        /// </summary>
        /// <returns>Lista ordenada</returns>
        public List<Pessoa> GetPessoasOrdenadasPorDataDeNascimentoDesc()
        {
            return ListaDePessoas.OrderByDescending(x => x.DataNascimento).ToList<Pessoa>();
        }
        /// <summary>
        /// Metodo que retorna as pessoas com determinado valor dentro da carteira
        /// </summary>
        /// <returns>Retorna a lista com o valor definido e ordenado</returns>
        public List<Pessoa> GetPessoasMaisDeQuinhentos(double valor = 500)
        {
            return ListaDePessoas.FindAll(x => x.Carteira > valor).OrderBy(x => x.Carteira).ToList<Pessoa>();
        }
        /// <summary>
        /// Metodo que retorna a lista de pessoas com idade maior que idade informada
        /// </summary>
        /// <param name="idade">Idade que vamos usar para compara</param>
        /// <returns>Retorna lista de pessoas pela idade informada</returns>
        public List<Pessoa> GetPessoasMaiorDeIdade(int idade = 18)
        {
            return ListaDePessoas.FindAll(i => (DateTime.Now.Year - i.DataNascimento.Year) > idade);
        }

        public List<Pessoa> GetPessoasMenorDezesseis(int idade = 15)
        {
            return ListaDePessoas.FindAll(i => (DateTime.Now.Year - i.DataNascimento.Year) < 16);
        }
    }
}