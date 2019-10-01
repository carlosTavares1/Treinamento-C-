using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> conjunto = new SortedSet<string>();

            conjunto.Add("jose");
            conjunto.Add("gabriel");
            conjunto.Add("carlos");

            foreach (var item in conjunto)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
