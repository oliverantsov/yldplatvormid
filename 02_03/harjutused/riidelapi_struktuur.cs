using System;

namespace Riidelapid{
    struct Riidelapp{
        public int pikkus;
        public int laius;
        public string toon;
    }

class riidelapi_struktuur{
    public static void Main(string[] arg){

        Riidelapp riidelapp1;
        riidelapp1.pikkus = 7;
        riidelapp1.laius = 5;
        riidelapp1.toon = "Punane";

        Riidelapp riidelapp2;
        riidelapp2.pikkus = 12;
        riidelapp2.laius = 8;
        riidelapp2.toon = "Kollane";

        Riidelapp riidelapp3=riidelapp2;

        riidelapp2.pikkus = 10;
        riidelapp2.toon = "Sinine";

        Console.WriteLine("Riidelapp nr 1 andmed:");
        Console.WriteLine(riidelapp1.pikkus + " " + riidelapp1.laius + " " + riidelapp1.toon);
        Console.WriteLine("Riidelapp nr 2 andmed:");
        Console.WriteLine(riidelapp2.pikkus + " " + riidelapp2.laius + " " + riidelapp2.toon);
        Console.WriteLine("Riidelapp nr 3 andmed:");
        Console.WriteLine(riidelapp3.pikkus + " " + riidelapp3.laius + " " + riidelapp3.toon);
    }
}
}
