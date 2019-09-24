using ExercicioAula11.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioAula11.Controller;

namespace ExercicioAula11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui carregamos nossa caixa de ferramentas de pessoas 
            //podemos agora listar as demais funcionalidades
            PessoaController pessoaController = new PessoaController();
            //Aqui acessamos nossa lista de pessoas
            pessoaController.ListaDePessoaPublica.ForEach(i => MostraInformacoes(i));
            Console.WriteLine("---------------------Lista ascendente ordenada por nome-------------------------");
            pessoaController.GetPessoasOrdenadasAsc().ForEach(i => MostraInformacoes(i));
            Console.WriteLine("---------------------Lista descendente ordenada por data de nascimento-------------------------");
            pessoaController.GetPessoasOrdenadasPorDataDeNascimentoDesc().ForEach(i => MostraInformacoes(i));
            Console.WriteLine("---------------------Lista de pessoas com mais de 500 reais na carteira-----------------------");
            pessoaController.GetPessoasMaisDeQuinhentos().ForEach(i => MostraInformacoes(i));
            Console.WriteLine("---------------------Lista de pessoas com mais de 18 anos-----------------------");
            pessoaController.GetPessoasMaiorDeIdade().ForEach(i => MostraInformacoes(i));
            Console.WriteLine("---------------------Lista de pessoas com menos de 16 anos-----------------------");
            pessoaController.GetPessoasMenorDezesseis().ForEach(i => MostraInformacoes(i));
            Console.ReadKey();

        }

        /// <summary>
        /// Metodo que mostra no console formatado nosso objeto
        /// </summary>
        /// <param name="pessoa">Objeto pessoa que vamos apresentar</param>
        private static void MostraInformacoes(Pessoa pessoa)
        {
            //Nosso template que apresenta as informações bonitinhas
            string template = "Id {0,3} Nome {1,10} Nascimento {2,10} Carteira {3,6}";
            //Recebemos as informações bonitinhas com o string format
            string textoFormatado = string.Format(template, pessoa.Id, pessoa.Nome, pessoa.DataNascimento.ToShortDateString(), pessoa.Carteira.ToString("C"));

            Console.WriteLine(textoFormatado);
        }
    }
}