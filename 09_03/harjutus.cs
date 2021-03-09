// [POOLIK] 
// [INCOMPLETE]

using System;

namespace AbstraktseKlassiUuring{

abstract class Kujund{   
    public abstract double KysiPohjaPindala();
    public abstract double KysiKorgus();
    public abstract double PohjaYmbermoot();
    public double KyljePindala(){
        return PohjaYmbermoot()*KysiKorgus();
    }
    public double KysiRuumala(){
        return KysiPohjaPindala()*KysiKorgus();
    }
}

class Tikutops:Kujund{
    public override double KysiPohjaPindala(){return 8;}
    public override double KysiKorgus(){return 1.5;}
    public override double PohjaYmbermoot(){
        return 12;
    }
}

class Vorstijupp:Kujund{
    int pikkus, raadius;
    public Vorstijupp(int upikkus, int uraadius){
        pikkus=upikkus;
        raadius=uraadius;
    }
    public override double KysiPohjaPindala(){
        return Math.PI*raadius*raadius;
    }
    public override double KysiKorgus(){
        return pikkus;
    }
    public override double PohjaYmbermoot(){
        return Math.PI*2*raadius;
    }
}

class Risttahukas:Kujund{
    int pikkus, laius, korgus;
    public Risttahukas(int pikkus, int laius, int korgus){
        this.pikkus=pikkus;
        this.laius=laius;
        this.korgus=korgus;
    }
    public override double KysiPohjaPindala(){
        return pikkus*laius;
    }
    public override double KysiKorgus(){
        return pikkus;
    }
    public override double PohjaYmbermoot(){
        return Math.PI*2*pikkus;
    }
}

class Test{
    public static void Main(string[] arg){
        Tikutops t=new Tikutops();
        Vorstijupp v=new Vorstijupp(10, 3);
        Risttahukas r=new Risttahukas(6, 4, 2);
        Console.WriteLine("Ruumalad {0} ja {1}", 
            t.KysiRuumala(), v.KysiRuumala());
        Console.WriteLine(v.KyljePindala);
    }
}
}
