using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoNomes.Model
{
    /// <summary>
    /// Esta classe possui os parâmetros que são inseridos pelo usuário e que variam
    /// </summary>
    public class NomePessoal : Controle
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Nome { get; set; }
        [MaxLength(30)]
        [Required]
        public string Origem { get; set; }
    }
}
