using System;
using mymathlib;
class MyMathApp
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calling Method from mymathlib");
        if (args.Length != 2)
        {
            Console.WriteLine("Usage :MyMathApp <num1> <num2>");
            return;
        }
        long num1 = long.Parse(args[0]);
        long num2 = long.Parse(args[1]);
        long add = MML.Add(num1, num2);
        long mul = MML.Mul(num1, num2);
        Console.WriteLine("{0} + {1} = {2}", num1, num2, add);
        Console.WriteLine("{0} * {1} = {2}", num1, num2, mul);
    }
}

// csc /reference:mymathlib.dll .\MyMathApp.cs
// .\MyMathApp.exe 10 20