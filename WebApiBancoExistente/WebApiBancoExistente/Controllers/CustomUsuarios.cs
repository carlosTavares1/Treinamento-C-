using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiBancoExistente.Controllers
{
    public partial class UsuariosController
    {
        [HttpGet]
        [Route("api/Usuarios/CustomQueryUsuarios")]
        public object CustomUsuariosQuery()
        {
            var listaDeUsuarios = db.Usuarios.ToList();
            var retornoUsuarios = from usuarios in listaDeUsuarios select new { NomeUsuarios = usuarios.Usuario };
            return retornoUsuarios;
        }
    }
}