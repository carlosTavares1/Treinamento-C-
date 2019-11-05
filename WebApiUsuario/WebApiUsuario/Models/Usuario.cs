using System;
using System.Collections.Generic;

namespace WebApiUsuario.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool? Ativo { get; set; }
        public int? UsuarioCriacao { get; set; }
        public int? UsuarioAlteracao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
