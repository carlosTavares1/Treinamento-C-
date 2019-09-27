using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Controller
{
    /// <summary>
    /// 
    /// </summary>
    public class CarroController
    {
        SistemaCarrosContext carroController = new SistemaCarrosContext();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Carro> MostrarLista()
        {
            return carroController.ListaPublicaDeCarro;
        }
    }
}
