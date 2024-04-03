using System;

namespace prrprrövningmedklasser1
{
    class Program
    {
        static void Main(string[] args)
        {
            bil b1 = new bil();

            b1.märke = "Volvo";
            b1.årsmodell = 1998;
            b1.färg = "röd";
            b1.modell = "V70";
            b1.bränslekapacitet = 70;

            bil b2 = new bil();
            b2.märke = "Volvvo";
            b2.årsmodell = 19968;
            b2.färg = "rövd";
            b2.modell = "Vy70";
            b2.bränslekapacitet = 710;

            person a1 = new person("Johan", "Johansson");

            person.utskrift(a1);
            bil.utskrift(b1);
            bil.utskrift(b2);
        }
    } 
}