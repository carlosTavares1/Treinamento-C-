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
        private LocacaoContext contextDB = new LocacaoContext();
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
            return RetornaListaDeUsuario().Exists(x => x.Login == usuario.Login && x.Senha == usuario.Senha);
        }
        public UsuarioController()
        {

        }
        /// <summary>
        /// Método para adicionar um novo usuário no sistema
        /// </summary>
        /// <param name="usuario">Novo usuário que será adicionado a lista</param>
        public void Usuario(Usuario usuario)
        {
            //Adiciona o meu usuário a minha lista
            usuario.Id = contextDB.IdContadorUsuarios++;
            contextDB.ListaDeUsuarios.Add(usuario);
        }
        /// <summary>
        /// Metodo que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns>Retorna a lista de usuarios</returns>
        public List<Usuario> RetornaListaDeUsuario()
        {
            //Retorna somente a lista de usuarios ativos com a expressão where
            return contextDB.ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadorId">Parametro que identifica o usuario dentro da lista</param>
        public void RemoverUsuarioPorId(int identificadorId)
        {
            //Aqui usamos o metodo firstordefault para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e desativar o registro
            contextDB.ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadorId).Ativo = false;
        }
    }
}
