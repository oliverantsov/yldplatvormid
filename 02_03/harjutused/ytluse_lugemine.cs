using System;
using System.IO;

class ytluse_lugemine{
public static void Main(string[] arg){
    Random r = new Random();
    FileStream f = new FileStream("ytlused.txt", FileMode.Open, FileAccess.Read);
    string[] read = File.ReadAllLines("ytlused.txt");
    Console.WriteLine(read[r.Next(read.Length)]);    
}
}