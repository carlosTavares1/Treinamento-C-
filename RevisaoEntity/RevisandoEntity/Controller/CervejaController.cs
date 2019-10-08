using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisandoEntity.Model;

namespace RevisandoEntity.Controller
{
    //Primeiro passo deixar ela publica
    public class CervejaController
    {
        CervejaContextDB contextDB = new CervejaContextDB();
        public void AddCerveja(Cerveja item)
        {
            if (item.Nome.Contains("Cerveja") || item.Nome.Contains("cerveja"))
            {
                contextDB.Cervejas.Add(item);
            }
            contextDB.SaveChanges();
        }

        public IQueryable<Cerveja> GetCervejas()
        {
            return contextDB.Cervejas.Where(x => x.Nome.Contains("Cerveja"));
        }
    }
}
