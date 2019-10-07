using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace InterfaceDoEntity
{
    class Program
    {
        static AlunoController aluno = new AlunoController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;
            while (opcao != 0)
            {
                Console.WriteLine("Informe o nome: ");
                var nome = Console.ReadLine();
                Console.WriteLine("Informe a idade: ");
                var idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite zero para sair e ver a lista");
                opcao = int.Parse(Console.ReadLine());
                aluno.AddAluno(new Aluno()
                {
                    Nome = nome,
                    Idade = idade
                });
            }

            aluno.GetAlunos().ToList<Aluno>().ForEach(i => Console.WriteLine($"Nome: {i.Nome} Idade: {i.Idade}"));

            Console.ReadKey();
        }
    }
}
