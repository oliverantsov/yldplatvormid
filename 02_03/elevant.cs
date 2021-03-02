using System;
public class elevant{

public static void Main(String[] arg){
    Console.WriteLine("Osta elevant ära!");
    string sisend = Console.ReadLine();
    while (sisend != "elevant") {
        Console.WriteLine("Osta ikka!");
        break;
    } 
    while (sisend == "elevant") {
        Console.WriteLine("TUBLI! Ostsid elevandi ära!");
        break;
    }
    }
}