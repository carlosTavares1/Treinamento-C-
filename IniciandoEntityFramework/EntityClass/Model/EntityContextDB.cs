using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    class EntityContextDB : 
        DbContext //DbContext classe pronta que contem todo os processo deconexão 
                 //com o banco de dados listagem das tabelas seleção das informações 
    {
        public DbSet//palavra reservada para o entity que dica que vamos definir uma tabela
            //do nosso banco de dados
            <Pessoa>//Aqui definimos nossa tabela pessoa ou seja especificamos
                   //qual de nossa classe será referencia de uma tabela no banco 
                  //de dados ela vai ao banco com o nome que definimos em nossa classe
            ListaDePessoas { get; set; }
    }
}
