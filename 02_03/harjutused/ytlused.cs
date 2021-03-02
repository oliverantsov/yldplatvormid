using System;
using System.IO;

class ytlused{
public static void Main(string[] arg){
    FileStream f = new FileStream("ytlused.txt", FileMode.Create, FileAccess.Write);
    StreamWriter v2ljund = new StreamWriter(f);
    v2ljund.WriteLine("See on fantastiline!");
    v2ljund.WriteLine("Suurepärane töö!");
    v2ljund.WriteLine("Uskumatult lahe!");
    v2ljund.WriteLine("Minule see ei meeldi.");
    v2ljund.WriteLine("Kui tore!");
    v2ljund.WriteLine("Minu arvamus on nii ja naa.");
    v2ljund.Close();     
}
}
