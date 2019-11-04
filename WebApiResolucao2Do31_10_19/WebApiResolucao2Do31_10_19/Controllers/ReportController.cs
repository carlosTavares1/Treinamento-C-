using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiResolucao2Do31_10_19.Models;

namespace WebApiResolucao2Do31_10_19.Controllers
{
    [RoutePrefix("Api/Reports")]
    public class ReportController : ApiController
    {
        Context db = new Context();

        [HttpGet]
        [Route("{ano}")]
        public object RelVendasAno(int ano)
        {
            var listaDeVendas = db.Vendas.Where(x => x.DatInc.Year == ano).ToList();
            var listaDeCarros = db.Carros.ToList();

            var conteudoRetorno = from ven in listaDeVendas
                                  join car in listaDeCarros
                                  on ven.Carro equals car.Id
                                  select new
                                  {
                                      IdVenda = ven.Id,
                                      Carros = car.Marca,
                                      Vendas = ven.Quantidade
                                  };


            return listaDeVendas;
        }

        [HttpGet]
        [Route("{ano}/{usuario}")]
        public object RelAnoUsuario(int ano, int usuario)
        {
            var listaDeUsuarios = db.Usuarios.ToList();
            var listaDeVendas = db.Vendas.Where(x => x.DatInc.Year == ano && x.UsuInc == usuario).ToList();
            var listaDeCarros = db.Carros.ToList();

            var retornoConteudo = from ven in listaDeVendas
                                  join car in listaDeCarros
                                  on ven.Carro equals car.Id
                                  join usu in listaDeUsuarios
                                  on ven.UsuInc equals usu.Id
                                  select new
                                  {
                                      IdVenda = ven.Id,
                                      Carros = car.Marca,
                                      Usuario = usu.Usuario1,
                                      Vendas = ven.Quantidade
                                  };
            return retornoConteudo;
        }
        [HttpGet]
        [Route("PorMarca/{ano}/{marca}")]
        public object RelAnoMarca(int ano, int marca)
        {
            var listaDeVendas = db.Vendas.Where(x => x.DatInc.Year == ano).ToList();
            var listaDeCarros = db.Carros.Where(x => x.Marca == marca);
            var listaDeMarcas = db.Marcas.ToList();

            var conteudoRetorno = from ven in listaDeVendas
                                  join car in listaDeCarros
                                  on ven.Carro equals car.Id
                                  join mar in listaDeMarcas
                                  on car.Marca equals mar.Id
                                  group new
                                  {
                                      ven, car, mar
                                  }
                                  by new
                                  {
                                      ven.DatAlt.Month, mar.Nome
                                  }
                                  into ingroup select new
                                  {
                                      PeriodoVenda = ingroup.Key.Month,
                                      MarcaVenda = ingroup.Key.Nome,
                                      ValorTotalVendas = ingroup.Sum(x => x.ven.Quantidade * x.ven.Valor)
                                  };


            return conteudoRetorno.OrderByDescending(X => X.ValorTotalVendas);
        }
    }
}
