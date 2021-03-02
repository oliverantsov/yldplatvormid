using System;

class Massiiv4{
public static void Main(string[] arg){
    int[] m=new int[5]{40, 48, 33, 21, 56};
    int suurim = m[0];
    Array.Sort(m);
    for(int i=0; i<m.Length; i++){
        Console.WriteLine(m[i]);
        if (m[i] > suurim)
            suurim = m[i];
            Console.WriteLine("Massiivi suurim element on: " + m[i]);
    }
    

}
}
