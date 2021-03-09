using System;
namespace Massiiv{

class Lapp{
    private int pikkus;
    private int laius;

    public Lapp(int pikkus, int laius){
        this.pikkus = pikkus;
        this.laius = laius;
    }
    public int GetPikkus(){
        return pikkus;
    }
    public int GetLaius(){
        return laius;
    }
    public double LapiPindala(){
        return pikkus*laius;
    }
}

class LapiKuvamine{
    public static void Main(string[] arg){

        Lapp[] riidelapid = new Lapp[3];
        riidelapid[0] = new Lapp(2, 3);
        riidelapid[1] = new Lapp(6, 6);
        riidelapid[2] = new Lapp(8, 10);

        Lapp[] kaltsukott = new Lapp[2];
        kaltsukott[0] = new Lapp(4, 8);
        kaltsukott[1] = new Lapp(6, 12);

        //Console.WriteLine(massiiv1[0].GetPikkus());
        //Console.WriteLine(massiiv2[1].GetLaius());

        Lapp[] yldMassiiv = new Lapp[5];
        yldMassiiv[0] = riidelapid[0];
        yldMassiiv[1] = kaltsukott[1];
        yldMassiiv[2] = riidelapid[2];
        yldMassiiv[3] = new Lapp(12, 12);
        yldMassiiv[4] = new Lapp(10, 16);

        Console.WriteLine(yldMassiiv[0].GetPikkus());
        Console.WriteLine(yldMassiiv[1].GetLaius());
        Console.WriteLine(yldMassiiv[2].GetPikkus());
        Console.WriteLine(yldMassiiv[3].GetLaius());
        Console.WriteLine(yldMassiiv[4].GetLaius());
    }
}
}




// ÕIGE LAHENDUS (KOOS PINDALADE ARVUTAMISEGA):
/*
using System;

namespace yldplatvormid_tund2
{
    class Punkt{
    static int loendur=0;
    private int nr;
    private int x;
    private int y;
    public Punkt(int ux, int uy){
        x=ux; y=uy;
        nr=++loendur;
    }
    public int GetX(){
        return x;
    }
    public int GetY(){
        return y;
    }
    public int GetNr(){
        return nr;
    }
    public void SetX(int ux){
        x=ux;
    }
    public void SetY(int uy){
        y=uy;
    }
    public double KaugusNullist(){
        return Math.Sqrt(x*x+y*y);
    }
}

class RiideLapp {
    private double pikkus, laius;
    private string toon;
    private static double koguPindala;
    public static int lappideArv;

    public RiideLapp(double pikkus, double laius, string toon) {
        this.pikkus = pikkus;
        this.laius = laius;
        this.toon = toon;
        lappideArv++;
        koguPindala += Pindala();
    }

    public double Pindala() {
        return this.pikkus * this.laius;
    }


    public string toString() {
        return "Pikkus: " + this.pikkus + " Laius: " + this.laius + " Toon: " + this.toon;
    }

    public RiideLapp poolPikkust() {
        return new RiideLapp((this.pikkus / 2), this.laius, this.toon);
    }

    public RiideLapp pooleV2iksem() {
        return new RiideLapp((this.pikkus / 2), (this.laius / 2), this.toon);
    }

    public RiideLapp protsentPikkus(double percentage) {
        return new RiideLapp((this.pikkus * (percentage / 100)), this.laius, this.toon);
    }

    public static double lappideKeskminePindala() {
        if (lappideArv != 0) {
            return koguPindala / lappideArv;
        } else {
            return -1;
        }
    }
        


}

    class Program
    {
        public static void Main(string[] arg){


        RiideLapp[] riidelapid = new RiideLapp[] {new RiideLapp(5, 5, "Punane"), new RiideLapp(10, 10, "Roheline"), new RiideLapp(2, 2, "Sinine")};
        RiideLapp[] kaltsud = new RiideLapp[] {new RiideLapp(3, 3, "Must"), new RiideLapp(20, 20, "Roheline")};

        RiideLapp[] uusArr = new RiideLapp[] {riidelapid[0], riidelapid[2], kaltsud[0]};

        System.Console.WriteLine("riidelapid massiivi pindalade summa: ");
        double riidelapidSumma = 0;

        for (int i = 0; i < riidelapid.Length; i++) {
            riidelapidSumma += riidelapid[i].Pindala();
        }
        System.Console.WriteLine(riidelapidSumma);

        System.Console.WriteLine("uusArr massiivi pindalade summa: ");
        double uusArrSumma = 0;

        for (int i = 0; i < uusArr.Length; i++) {
            uusArrSumma += uusArr[i].Pindala();
        }
        System.Console.WriteLine(uusArrSumma);
        System.Console.WriteLine(RiideLapp.lappideKeskminePindala());
        System.Console.WriteLine(RiideLapp.lappideArv);

    }

    }
}
*/
