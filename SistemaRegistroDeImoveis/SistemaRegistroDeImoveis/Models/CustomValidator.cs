using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaRegistroDeImoveis.Models
{

    public class CustomValidator : ValidationAttribute
    {
        ProprietarioContext db = new ProprietarioContext();
        //object value é toda a informação colocada em nossa propriedade
        //
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
             if (db.Proprietarios.FirstOrDefault(x => x.Nome == value.ToString()) != null)
               return new ValidationResult("Usuários já cadastrado no sistema");


            if (validationContext.DisplayName == "DataNascimento")
            {
                var dataInformada = DateTime.Parse(value.ToString());

                var idade = DateTime.Now.Year - dataInformada.Year;

                if (idade < 18)
                    return new ValidationResult("É preciso ser maior ou igual a 18 anos!");
                if (idade > 150)
                    return new ValidationResult("Idade apresentada superior ao maximo");
            }
            

            
            return ValidationResult.Success;
        }
    }
}