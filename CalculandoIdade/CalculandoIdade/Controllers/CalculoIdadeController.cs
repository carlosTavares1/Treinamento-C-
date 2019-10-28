using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    public class CalculoIdadeController : ApiController
    {
        /// <summary>
        /// Retorna nome da aplicação
        /// </summary>
        /// <returns>Retorna o que nosso app faz
        /// </returns>
        public string Get()
        {
            return "App para poder beber hoje";
        }

        public string Get(int anoNascimento,string nomeUsuario)
        {
            string retorno = "Nada ocorreu";
            if (DateTime.Now.Year - anoNascimento >= 18)
            {
                return $"Olá {nomeUsuario} De acordo com os calculos realizados em nosso servidor " + "o sistema identifica que voce poderá desfrutar de" + "recursos hídricos alcoolicos";
            }
            else
            {
                return $"Olá {nomeUsuario} Felizmente as fazendas em nosso territorio ainda produzem" + "leite e sucos naturais para voce desfrutar.";
            }
        }
    }
}
