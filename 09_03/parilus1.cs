using System;
namespace Parilus1{
class Inimene{
    protected int vanus;
    public Inimene(int uvanus){
    vanus=uvanus;
    }
    public void YtleVanus(){
        Console.WriteLine("Minu vanus on "+vanus+" aastat");
    }
}

class InimTest{
    public static void Main(string[] arg){
        Inimene inim1=new Inimene(13);
        inim1.YtleVanus();     
    }
}
}
