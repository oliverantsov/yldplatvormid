using System;

class arvud_tagurpidi{
public static void Main(string[] arg){
    int[] m=new int[10]{2, 4, 6, 8, 10, 12, 14, 16, 18, 20};
    Console.WriteLine("Arvud õiges järjekorras: ");
    foreach (int arv in m) {
        Console.WriteLine(arv);
    }
    Array.Reverse(m);
    Console.WriteLine("Arvud tagurpidi: ");
    foreach (int arv in m) {
        Console.WriteLine(arv);
    }
}
}