using System;
public class juhuslik_lause{

public static void Main(String[] arg){
    Random r = new Random();
    string[] laused = {"Aias sadas saia.", "Täna on soe ilm!", "See on väga vahva!", "Mis sa parasjagu teed?", "Juku mängis jalgpalli.", "See on C# keel."};
    Console.WriteLine(laused[r.Next(laused.Length)]);
    }
}