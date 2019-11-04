using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiExercicio2_31_10_19.Controllers
{
    public partial class VendasController
    {
        [HttpGet]
        [Route("api/Vendas/CustomVendasOnCarros/{ano}")]
        public object CustomVendasOnCarros(int ano)
        {
            var listaVendas = db.Vendas.ToList();
            var listaUsuarios = db.Usuarios.ToList();

            var conteudoRetorno = from ven in listaVendas
                                  join usu in listaUsuarios on ven.UsuInc equals usu.Id
                                  where ven.DatInc.Year == ano
                                  select new
                                  {
                                      Usuario = usu.Usuario1,
                                      ValorVenda = ven.Valor
                                  };
            return conteudoRetorno;
        }

        [HttpGet]
        [Route("api/Vendas/CustomVendasCarros/{ano}")]
        public object CustomVendasCarros(int ano)
        {
            var listaVendas = db.Vendas.ToList();

            var conteudoRetorno = from ven in listaVendas
                                  where ven.DatInc.Year == ano
                                  select new
                                  {
                                      ValorVenda = ven.Valor
                                  };
            return conteudoRetorno;
        }

        [HttpGet]
        [Route("api/Vendas/CustomVendasMarcas/{marca}/{ano}")]
        public object CustomVendasMarcas(string marcas, int ano)
        {
            var listaVendas = db.Vendas.ToList();
            var listaMarcas = db.Marcas.ToList();
            var listaCarro = db.Carros.ToList();

            var conteudoRetorno = from ven in listaVendas
                                  join mar in listaMarcas on ven.UsuInc equals mar.Id
                                  join car in listaCarro on mar.Id equals car.Marca
                                  where mar.Nome == marcas & ven.DatInc.Year == ano
                                  select new
                                  {
                                      Marca = mar.Nome,
                                      Vendas = ven.Valor,
                                      Carro = car.Modelo
                                  };
            return conteudoRetorno;
        }

    }
}