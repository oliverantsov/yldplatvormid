using System;
public class hinnasoodus{

public static void Main(String[] arg){
    Console.WriteLine("30% soodustusega asja hind: ");
    decimal soodushind = decimal.Parse(Console.ReadLine());
    decimal tavahind = soodushind * 100 / 70;
    Console.WriteLine("Toote tavahind on " +  tavahind);
    }
}