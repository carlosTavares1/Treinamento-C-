using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreWebApi.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }
        public string Modelo { get; set; }
    }
}
