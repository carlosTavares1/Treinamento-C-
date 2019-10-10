using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    /// <summary>
    /// Esta classe armazena os atributos que são requeridos pelo sistema
    /// </summary>
    public class Produto : Controle
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Nome { get; set; }
        [Required]
        public double Valor { get; set; }
    }
}
