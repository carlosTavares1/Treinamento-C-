using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoNomes.Model
{
    /// <summary>
    /// Esta classe possui as propriedades que fazem o controle das classe como se ele deve ser retornado ou não e data de alteraçaõ
    /// </summary>
    public class Controle
    {
        public bool Ativo { get; set; } = true;
        public int UsuarioCriacao { get; set; } = 0;
        public int UsuarioAlteracao { get; set; } = 0;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
