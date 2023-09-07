using System;
using System.IO.Compression;
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DoanThiQuynhChi - 2021050114");
        int a,b;
        System.Console.Write(" a = ");
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write(" b = ");
        b = Convert.ToInt32(Console.ReadLine());
        if(a < b)
        {
            System.Console.WriteLine(a + "<" + b);
        }else if (a > b){
            System.Console.WriteLine(a + ">" + b);
        }else if (a == b){
            System.Console.WriteLine(a + "=" + b);
        }
    
    }

}
