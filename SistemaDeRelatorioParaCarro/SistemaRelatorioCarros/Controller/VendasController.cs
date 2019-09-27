using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Model;

namespace SistemaRelatorioCarros.Controller
{
    public class VendasController
    {
        RelatorioCarrosContext vendasContext = new RelatorioCarrosContext();
        public List<Venda> GetVendas(int mes = 0)
        {
            if (mes == 0)
                return vendasContext.ListaVendaPublica;
            else
                return vendasContext.ListaVendaPublica.FindAll(x => x.Data.Month == mes);
        }
    }
}
