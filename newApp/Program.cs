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
         int c=a-b;
        int d=a*b;
        int e=a/b;
        int f=a%b;
        System.Console.WriteLine("gia tri cua c= " +c);
        System.Console.WriteLine("gia tri cua d= " +d);
        System.Console.WriteLine("gia tri cua e= " +e,"va phan du la: "+f);
        System.Console.WriteLine("va phan du la: "+f);

    
    }

}
