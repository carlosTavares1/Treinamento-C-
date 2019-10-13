using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoNomes.Model;

namespace ListandoNomes.Controller
{
    /// <summary>
    /// Esta classe realiza o controle das informações na base de dados
    /// </summary>
    public class NomesController
    {
        NomeContextDB contextDB = new NomeContextDB();
        /// <summary>
        /// Este método é responsável por realizar a busca dos registros ativos na base de dados
        /// </summary>
        /// <returns>Retorna uma lista como iqueryable, sendo necessário conversão na hora de exibir</returns>
        public IQueryable<NomePessoal> GetNomePessoals()
        {
            return contextDB.NomePessoals.Where(x => x.Ativo == true);
        }
        /// <summary>
        /// Este método faz a inserção de novos nomes no sistema na base de dados
        /// </summary>
        /// <param name="nomePessoal">Recebe como parâmetro um objeto do tipo NomePessoal</param>
        /// <returns>Retorna verdadeiro caso os dados estejam inseridos de forma correta</returns>
        public bool InsertNomePessoal(NomePessoal nomePessoal)
        {
            if (string.IsNullOrWhiteSpace(nomePessoal.Nome))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(nomePessoal.Origem))
            {
                return false;
            }
            contextDB.NomePessoals.Add(nomePessoal);
            contextDB.SaveChanges();
            return true;
        }
    }
}
