using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BicicletaLibrary.Model;

namespace BicicletaLibrary.Controller
{
    public class ControleBicicleta
    {
        ContextDB context = new ContextDB();
        /// <summary>
        /// Este método pega na base de dados os registros ativos no sistema
        /// </summary>
        /// <returns>Retorna a lista</returns>
        public IQueryable<Bicicleta> GetBicicletas()
        {
            return context.Bicicletas.Where(x => x.Ativo == true);
        }
        /// <summary>
        /// Este método promove a inserção de valores na base de dados
        /// </summary>
        /// <param name="bicicleta">E recebe como parâmetro bicicleta do tipo bicicleta</param>
        /// <returns>Retorna um valor verdadeiro caso esteja tudo de acordo</returns>
        public bool InserirBicicleta(Bicicleta bicicleta)
        {
            if (string.IsNullOrWhiteSpace(bicicleta.Marca))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(bicicleta.Modelo))
            {
                return false;
            }
            if(bicicleta.Valor < 0)
            {
                return false;
            }
            context.Bicicletas.Add(bicicleta);
            context.SaveChanges();
            return true;
        }
        /// <summary>
        /// Este método realiza a remoção de um registro na base de dados
        /// </summary>
        /// <param name="bicicleta">Recebe como parâmetro um objeto do tipo bicicleta</param>
        /// <returns>Retorna um valor verdadeiro caso tudo esteja de acordo</returns>
        public bool RemoverBicicleta(Bicicleta bicicleta)
        {
            var relacao = context.Bicicletas.FirstOrDefault(x => x.Id == bicicleta.Id);
            if(relacao == null)
            {
                return false;
            }
            relacao.Ativo = false;
            context.SaveChanges();
            return true;
        }
        /// <summary>
        /// Este método altera um registro na base de dados
        /// </summary>
        /// <param name="bicicleta">Recebe como parâmetro um objeto do tipo bicicleta</param>
        /// <returns>E retorna um valor verdadeiro caso esteja tudo de acordo</returns>
        public bool AlterarBicicleta(Bicicleta bicicleta)
        {
            var alteracao = context.Bicicletas.FirstOrDefault(x => x.Id == bicicleta.Id);
            if(alteracao == null)
            {
                return false;
            }
            else
            {
                alteracao.DataAlteracao = DateTime.Now;
            }
            context.SaveChanges();
            return true;
        }
    }
}
