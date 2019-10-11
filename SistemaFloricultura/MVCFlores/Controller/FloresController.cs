using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCFlores.Model;

namespace MVCFlores.Controller
{
    public class FloresController
    {
        ContextDB contextDB = new ContextDB();
        /// <summary>
        /// Este método faz a varredura dos valores na base de dados e retorna os registros que estão ativos na base de dados
        /// </summary>
        /// <returns>Ele retorna somente os registros ativos</returns>
        public IQueryable<Flor> GetFlors()
        {
            return contextDB.Flors.Where(x => x.Ativo == true);
        }
        /// <summary>
        /// Este método faz a verificação das informações se estão corretas e adiciona na base de dados
        /// </summary>
        /// <param name="flor">Recebe como parâmetro um objeto do tipo Flor</param>
        /// <returns>Retorna verdadeiro caso as informações estejam corretas</returns>
        public bool InserirFlor(Flor flor)
        {
            if (string.IsNullOrWhiteSpace(flor.Nome))
            {
                return false;
            }
            if (flor.Quantidade <= 0)
            {
                return false;
            }
            contextDB.Flors.Add(flor);
            contextDB.SaveChanges();
            return true;
        }
    }
}
