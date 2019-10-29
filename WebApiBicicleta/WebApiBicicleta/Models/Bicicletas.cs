namespace WebApiBicicleta.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bicicletas
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Modelo { get; set; }

        [Required]
        [StringLength(30)]
        public string Marca { get; set; }

        public double Valor { get; set; }

        public bool Ativo { get; set; }

        public int UsuarioCriacao { get; set; }

        public int UsuarioAlteracao { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataAlteracao { get; set; }
    }
}
