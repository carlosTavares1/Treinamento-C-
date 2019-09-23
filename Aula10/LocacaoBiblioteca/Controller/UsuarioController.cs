using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contem os metodos de usuarios do sistema
    /// </summary>
    public class UsuarioController
    {
        /// <summary>
        /// metodo que realizad o login dentro do nosso sistema
        /// para realizar o login padrão use: 
        /// -login: admin
        /// -senha: admin
        /// </summary>
        /// <param name="usuario">Passamos um objeto de nome usuario como parametro</param>
        /// <returns>Retorna verdadeiro quando existir o usuário com este login e senha</returns>
        public bool LoginSistema(Usuario usuario)
        {
            return Usuarios.Exists(x => x.Login == usuario.Login && x.Senha == usuario.Senha);
        }

        public List<Usuario> Usuarios { get; set; }
        public UsuarioController()
        {
            Usuarios = new List<Usuario>();

            Usuarios.Add(new Usuario()
            {
                Login = "Admin",
                Senha = "Admin",
                Id = 0
            });

            Usuarios.Add(new Usuario()
            {
                Login = "cast.3@hotmail.com",
                Senha = "123456"
            });
        }

        public void Usuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }
    }
}
