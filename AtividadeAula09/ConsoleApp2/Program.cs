using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa p1 = new Pessoa();
            p1.Nome = "Gabriel";
            p1.Idade = 21;
            p1.Sexo = 'M';
            p1.Altura = 2.01;
            pessoas.Add(p1);

            Pessoa p2 = new Pessoa();
            p2.Nome = "Elora";
            p2.Idade = 21;
            p2.Sexo = 'F';
            p2.Altura = 1.53;
            pessoas.Add(p2);

            Pessoa p3 = new Pessoa();
            p3.Nome = "Elora";
            p3.Idade = 21;
            p3.Sexo = 'F';
            p3.Altura = 1.53;
            pessoas.Add(p2);
        }
    }
}
