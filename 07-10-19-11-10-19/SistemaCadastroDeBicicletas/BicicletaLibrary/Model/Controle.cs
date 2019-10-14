using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaLibrary.Model
{
    public class Controle
    {
        /// <summary>
        /// ESta propriedade indica se um elemento está ativo ou não no sistema
        /// </summary>
        public bool Ativo { get; set; } = true;
        /// <summary>
        /// Esta propriedade indica qual usuário realizou criação no sistema
        /// </summary>
        public int UsuarioCriacao { get; set; } = 0;
        /// <summary>
        /// Esta propriedade indica qual usuário fez alteração no sistema
        /// </summary>
        public int UsuarioAlteracao { get; set; } = 0;
        /// <summary>
        /// Esta propriedade indica qual a data de criação de algo no sistema
        /// </summary>
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        /// <summary>
        /// Esta propriedade indica a data de alteração que foi realizada no sistema
        /// </summary>
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
