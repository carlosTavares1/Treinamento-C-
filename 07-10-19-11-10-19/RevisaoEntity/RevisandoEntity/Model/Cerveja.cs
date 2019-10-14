using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    //Inicialmente devemos deixar a classe publica
    public class Cerveja
    {
        [Key] //Chave primária, auto incrementada
        public int Id { get; set; }
        //Aqui definimos a quatidade maxima de caracteres 
        [StringLength(50)] //para nosso campo "Nome" dentro do banco
        [Required()] //Identifica que este campo é obrigatório
        public string Nome { get; set; }
        [StringLength(30)]
        public string Tipo { get; set; }
        public double Teor { get; set; }
    }
}
