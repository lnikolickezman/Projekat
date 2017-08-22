using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Broj = 2;
            p.Ime = "Pera";
            Console.WriteLine("Genres: {0}, {1}", p.Broj, p.Ime);
            Console.WriteLine("{0}", p);
            Console.ReadKey();
        }
    }
}
