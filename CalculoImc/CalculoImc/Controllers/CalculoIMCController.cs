using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculoImc.Controllers
{
    //com este comando abaixo liberamos para todos os sites se conectar em nossa api
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoIMCController : ApiController
    {
        public string Get(string nome, double peso, double altura)
        {
            double imc = peso / (altura * altura);
            return $"Olá {nome} seu IMC é {imc} e ele foi calculado de acordo com sua altura:{altura} e peso:{peso}";
        }
    }
}
