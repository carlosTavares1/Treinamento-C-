using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext sistemaCervejaContext = new SistemaCervejaContext();
        
        /// <summary>
        /// Este método é definido como tipo lista Cerveja
        /// </summary>
        /// <returns>Retorna a lista de cerveja</returns>
        public List<Cerveja> GetCervejaContext()
        {
            return sistemaCervejaContext.ListaDeCerveja;
        }
        /// <summary>
        /// Método que permite a inserção de informação na lista
        /// </summary>
        /// <param name="cerveja">Recebe como parâmtro um objeto do tipo cerveja</param>
        public void SetCervejaContext(Cerveja cerveja)
        {
            sistemaCervejaContext.ListaDeCerveja.Add(cerveja);
        }
        public double SumValorCervejaContext()
        {
            return sistemaCervejaContext.ListaDeCerveja.Sum(x => x.Valor);
        }
        public double SumLitrosCervejaContext()
        {
            return sistemaCervejaContext.ListaDeCerveja.Sum(x => x.Litros);
        }
    }
}
