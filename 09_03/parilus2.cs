using System;
namespace Parilus2{

class Inimene{
    protected int vanus;
    protected double pikkus;
    public Inimene(int uvanus, double upikkus){
        vanus=uvanus;
        pikkus=upikkus;
    }
    public void YtleVanus(){
        Console.WriteLine("Vanus: "+vanus+" aastat");
    }
}

class Modell:Inimene {
    protected int ymberm66t;
    public Modell(int vanus, int uymberm66t, double pikkus):base(vanus, pikkus){
        ymberm66t=uymberm66t;
    }
    public void Esitle(){
        Console.WriteLine("-----------------------");
        YtleVanus();
        Console.WriteLine("-----------------------");
        Console.WriteLine("Ümbermõõt: "+ymberm66t+" cm");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Pikkus: "+pikkus+" cm");
        Console.WriteLine("-----------------------");
    }
}

class InimTest{
    public static void Main(string[] arg){
        Inimene[] inimesed = new Inimene[6];
        inimesed[0] = new Inimene(20, 179);
        inimesed[1] = new Inimene(19, 177);
        inimesed[2] = new Modell(19, 93, 180);
        inimesed[3] = new Modell(21, 81, 171);
        inimesed[4] = new Inimene(21, 188);
        inimesed[5] = new Modell(20, 85, 174);

        foreach (Inimene i in inimesed){
            i.YtleVanus();
        }
    }
}
}
