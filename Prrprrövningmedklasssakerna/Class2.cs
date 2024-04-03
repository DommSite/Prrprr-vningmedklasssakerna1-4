using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prrprrövningmedklasser1
{
    class person
    {
        string förnamn;
        string efternamn;


        public person(string förnamn, string efternamn)
        {
            this.förnamn = förnamn;
            this.efternamn = efternamn;
        }

         public static void utskrift(person a)
        {
            Console.WriteLine(a.förnamn);
            Console.WriteLine(a.efternamn);
            Console.WriteLine(a.förnamn + a.efternamn);
        }
    }
}
