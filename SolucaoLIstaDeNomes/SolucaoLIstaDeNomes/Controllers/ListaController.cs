using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using SolucaoLIstaDeNomes.Models;

namespace SolucaoLIstaDeNomes.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ListaController : ApiController
    {
        List<Pessoa> listaDePessoas = new List<Pessoa>() {
            new Pessoa(){Nome = "Carlos", Idade = 25},
            new Pessoa(){Nome = "Marcos", Idade = 28},
            new Pessoa(){Nome = "Felipe", Idade = 30},
            new Pessoa(){Nome = "João", Idade = 31},
            new Pessoa(){Nome = "Castro", Idade = 38},
            new Pessoa(){Nome = "Jose", Idade = 40},
            new Pessoa(){Nome = "Fabio", Idade = 24},
            new Pessoa(){Nome = "Juca", Idade = 18},
            new Pessoa(){Nome = "Joaozinho", Idade = 32},
            new Pessoa(){Nome = "Joaquim", Idade = 44},
        };
        public List<Pessoa> Get()
        {
            return listaDePessoas;
        }
    }
}
