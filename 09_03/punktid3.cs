using System;
namespace Punktid3{

class Punkt{
    private int x;
    private int y;
    public Punkt(int ux, int uy){
        x=ux; y=uy;
    }
    public int GetX(){
        return x;
    }
    public int GetY(){
        return y;
    }
    public double KaugusNullist(){
        return Math.Sqrt(x*x+y*y);
    }
}
class Punktiproov{
    public static void Main(string[] arg){
        Punkt p1=new Punkt(3, 4);
        Console.WriteLine(p1.GetX());
        Console.WriteLine(p1.KaugusNullist());
    }
}
}
