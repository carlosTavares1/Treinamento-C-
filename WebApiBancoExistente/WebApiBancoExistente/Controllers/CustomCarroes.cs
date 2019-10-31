using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiBancoExistente.Controllers
{
    public partial class CarrosController
    {

        [HttpGet]
        [Route("api/Carros/CustomQuery")]
        public object CustomCarrosQuery()
        {
            var listaDeCarros = db.Carros.ToList();
            var retornoCarros = from carros in listaDeCarros select new { NomeCarro = carros.Modelo, CarroId = carros.Id };
            return retornoCarros;
        }

        [HttpGet]
        [Route("api/Carros/CarrosComMarcas")]
        public object CustomCarrosOnMarcas()
        {
            var listCarros = db.Carros.ToList();
            var listMarcas = db.Marcas.ToList();

            var conteudoRetorno = from mar in listMarcas
                                  join car in listCarros on mar.Id equals car.Marca
                                  select new
                                  {
                                      CarrosId = car.Id,
                                      CarroNome = car.Modelo,
                                      MarcaId = mar.Id,
                                      MarcaNome = mar.Nome
                                  };
            return conteudoRetorno;
        }

        [HttpGet]
        [Route("api/Carros/CarrosComUsuarios/{id}")]
        public object CustomCarrosOnUsuarios(int id)
        {
            var listaCarros = db.Carros.ToList();
            var listaUsuarios = db.Usuarios.ToList();

            var conteudoRetorno = from usu in listaUsuarios
                                  join car in listaCarros on usu.Id equals car.UsuInc
                                  where car.Id == id
                                  select new
                                  {
                                      CarrosId = car.Id,
                                      CarroNome = car.Modelo,
                                      UsuarioId = usu.Id,
                                      UsuarioNome = usu.Usuario
                                  };
            return conteudoRetorno;
        }

    }
}