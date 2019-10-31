using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiBancoExistente.Controllers
{
    public partial class MarcasController
    {
        [HttpGet]
        [Route("api/Marcas/CustomQueryMarcas")]
        public object CustomMarcasQuery()
        {
            var listaDeMarcas = db.Marcas;
            var retornoMarcas = from marcas in listaDeMarcas select new { NomeMarca = marcas.Nome };
            return retornoMarcas;
        }
    }
}