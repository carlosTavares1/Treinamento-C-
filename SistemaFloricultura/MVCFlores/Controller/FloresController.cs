using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCFlores.Model;

namespace MVCFlores.Controller
{
    class FloresController
    {
        ContextDB contextDB = new ContextDB();

        public IQueryable<Flor> Flors()
        {
            return contextDB.Flors.Where(x => x.Ativo == true)
        }

        public bool InserirFlor()
        {

        }
    }
}
