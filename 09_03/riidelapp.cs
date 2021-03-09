using System;
namespace Riidelapp{

class Lapp{
    private int pikkus;
    private int laius;
    private string toon;

    public Lapp(int pikkus, int laius, string toon){
        this.pikkus = pikkus;
        this.laius = laius;
        this.toon = toon;
    }

    public int GetPikkus(){
        return pikkus;
    }
    public int GetLaius(){
        return laius;
    }
    public string GetToon(){
        return toon;
    }
    public double LapiPindala(){
        return pikkus*laius;
    }

    public double Poolitamine(){
        if(pikkus > laius){
            return pikkus / 2;
        }
        return laius / 2;
    }
}

class LapiKuvamine{
    public static void Main(string[] arg){
        Lapp lapp1=new Lapp(3, 4, "Sinine");
        Lapp lapp2=new Lapp(5, 8, "Punane");

        Console.WriteLine("---------------");
        Console.WriteLine("Lapp 1 ANDMED:");
        Console.WriteLine(lapp1.GetPikkus());
        Console.WriteLine(lapp1.GetLaius());
        Console.WriteLine(lapp1.GetToon());
        Console.WriteLine("---------------");

        Console.WriteLine("Lapp 2 ANDMED:");
        Console.WriteLine(lapp2.GetPikkus());
        Console.WriteLine(lapp2.GetLaius());
        Console.WriteLine(lapp2.GetToon());
        Console.WriteLine("----------------");

        Console.WriteLine("Lapp 1 PINDALA:");
        Console.WriteLine(lapp1.LapiPindala());
        Console.WriteLine("----------------");
        Console.WriteLine("Lapp 2 PINDALA:");
        Console.WriteLine(lapp2.LapiPindala());
        Console.WriteLine("--------------------");

        Console.WriteLine("Lapp 1 POOLITAMINE:");
        Console.WriteLine(lapp1.Poolitamine());
        Console.WriteLine("--------------------");
        Console.WriteLine("Lapp 2 POOLITAMINE:");
        Console.WriteLine(lapp2.Poolitamine());
    }
}
}