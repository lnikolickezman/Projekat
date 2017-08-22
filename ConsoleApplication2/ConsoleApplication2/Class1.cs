using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Person
    {
        private int broj;
        private string ime;

        public int Broj
        {
            get
            {
                return broj;
            }

            set
            {
                broj = value;
            }
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public override string ToString()
        {
            return "Person: 1.1 " + Ime + " " + Broj;
        }

    }
}
