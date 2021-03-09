using System;
namespace Parilus3{
 class Inimene{
   protected int vanus;
   public Inimene(int uvanus){
      vanus=uvanus;
   }
   public virtual void YtleVanus(){
      Console.WriteLine("Minu vanus on "+vanus+" aastat");
   }
 }
 class Daam:Inimene {
   public Daam(int vanus):base(vanus){}
   public override void YtleVanus(){
      Console.WriteLine("Minu vanus on "+(vanus-5)+" aastat");   
   }
 }
 class InimTest{
  public static void Main(string[] arg){
     Inimene inim1=new Inimene(40);
     Daam inim2=new Daam(40);
     inim1.YtleVanus();
     inim2.YtleVanus();
  }
 }
}
