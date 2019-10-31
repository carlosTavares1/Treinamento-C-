using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiBancoExistente.Controllers
{
    public partial class VendasController
    {
        [HttpGet]
        [Route("api/Marcas/CustomQueryVendas")]
        public object CustomVendasQuery()
        {
            var listaDeVendas = db.Vendas.ToList();
            var retornoVendas = from vendas in listaDeVendas select new { NomeVendas = vendas.Carro };
            return retornoVendas;
        }
    }
}