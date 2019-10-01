using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class MostrarLista
    {
        public static void nameCerveja()
        {
            var nomeCerveja = new List<string>() {"\r\nBrahma", "Corona", "Skol", "Stella Artois", "Budweiser\r\n" };
            foreach (var item in nomeCerveja)
            {
                Console.WriteLine(item);
            }
        }    
    }
}
