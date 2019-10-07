using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class Pessoa
    {
        [Key] //Aqui temos uma notação que indica que nossa chave é o campo logo
             //abaixo da nossa anotação
            //significa que ele é nossa chave primaria
        public int Id { get; set; }
        /// <summary>
        /// Esta propriedade recebe nome
        /// </summary>
        public string Nome { get; set; }
    }
}
