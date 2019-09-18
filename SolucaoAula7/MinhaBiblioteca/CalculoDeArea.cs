using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CalculoDeArea
    {
        /// <summary>
        /// metodo para retornar a area de um quadrado
        /// </summary>
        /// <param name="ladoDoQuadrado">lado do quadrado</param>
        /// <returns>retorna a area total do quadrado</returns>
        public double CalculaAreaDoQuadrado(int ladoDoQuadrado)
        {
            return ladoDoQuadrado * ladoDoQuadrado;
        }
    }
}
