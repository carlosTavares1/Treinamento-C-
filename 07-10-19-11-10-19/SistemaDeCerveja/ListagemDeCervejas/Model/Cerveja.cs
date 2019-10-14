using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class Cerveja
    {
        /// <summary>
        /// Propriedade que armazena id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Propriedade que armazena o nome da cerveja
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Propriedade que armazena a quantidade de litros por unidade
        /// </summary>
        public double Litros { get; set; }
        /// <summary>
        /// Propriedade que armazena percentual de alcool por unidade
        /// </summary>
        public double Alcool { get; set; }
        /// <summary>
        /// Propriedade que armazena o valor por unidade da cerveja
        /// </summary>
        public double Valor { get; set; }
    }
}
