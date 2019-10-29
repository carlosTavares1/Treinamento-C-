using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CalculoImc.Models;

namespace CalculoImc.Controllers
{
    //com este comando abaixo liberamos para todos os sites se conectar em nossa api
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoIMCController : ApiController
    {
        List<ObjetoImc> listaDeObjetos = new List<ObjetoImc>() {
            new ObjetoImc(){Nome="Felipe"},
            new ObjetoImc(){Nome="Clibar"},
            new ObjetoImc(){Nome="Giomar"}
        };

        public List<ObjetoImc> Get()
        {
            return listaDeObjetos;
        }
        public string Get(string nome, double peso, double altura)
        {
            double imc = peso / (altura * altura);
            return $"Olá {nome} seu IMC é {imc} e ele foi calculado de acordo com sua altura:{altura} e peso:{peso}";
        }

        public ObjetoImc Post(ObjetoImc value)
        {
            ObjetoImc objetoImc = value;
            objetoImc.ImcValue = objetoImc.Peso / (objetoImc.Altura * objetoImc.Altura);
            listaDeObjetos.Add(objetoImc);
            return objetoImc;
        }
    }
}
