using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prrprrövningmedklasser1
{
    class bil
    {
        public string märke;
        public int årsmodell;
        public string färg;
        public string modell;
        public int bränslekapacitet;

        public static void utskrift(bil bilen)
        {
            Console.WriteLine(bilen.märke);
            Console.WriteLine(bilen.årsmodell);
            Console.WriteLine(bilen.färg);
            Console.WriteLine(bilen.modell);
            Console.WriteLine(bilen.bränslekapacitet);
        }
    }
}
