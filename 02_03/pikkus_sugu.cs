using System;
public class pikkus_sugu{

public static void Main(String[] arg){
    Console.WriteLine("Sisesta enda sugu: ");
    string sugu = Console.ReadLine();
    Console.WriteLine("Sisesta enda pikkus (cm): ");
    int pikkus = int.Parse(Console.ReadLine());
    if (sugu == "M"){
        Console.WriteLine("Oled mees.");
        if(pikkus > 180 && pikkus < 300){
            Console.WriteLine("Oled pikka kasvu!");
        }
        else if(pikkus > 160 && pikkus < 180){
            Console.WriteLine("Oled keskmist kasvu!");
        }
        else if(pikkus > 0 && pikkus < 160){
            Console.WriteLine("Oled lühikest kasvu!");
        }
    }
    else if (sugu == "N"){
        Console.WriteLine("Oled naine.");
        if(pikkus > 170 && pikkus < 300){
            Console.WriteLine("Oled pikka kasvu!");
        }
        else if(pikkus > 150 && pikkus < 170){
            Console.WriteLine("Oled keskmist kasvu!");
        }
        else if(pikkus > 0 && pikkus < 150){
            Console.WriteLine("Oled lühikest kasvu!");
        }
    }
    }
}