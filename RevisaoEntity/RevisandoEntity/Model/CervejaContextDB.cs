using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    public class CervejaContextDB : DbContext
    {
        //Definimos nossa tabela dentro do banco de dados
        public DbSet<Cerveja> Cervejas { get; set; }
    }
}
