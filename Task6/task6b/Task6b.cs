using System;
using System.Text;
class StringBuilderDemo
{
    public static void Main(string[] a)
    {
        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder("parameters");
        StringBuilder sb3 = new StringBuilder(50);
        StringBuilder sb4 = new StringBuilder("two parameters", 50);

        sb1.Append("Word1");
        sb1.Append("Word2");
        sb1.AppendLine();
        sb1.AppendLine("New line");

        Console.WriteLine("sb1 is :" + sb1);
        Console.WriteLine("sb2 is:" + sb2);

        Console.WriteLine("sb2 after Change:");
        sb2.Insert(4, "123");
        Console.WriteLine(sb2);

        Console.WriteLine();
        Console.WriteLine("Capacity of String builder 1 :" + sb1.Capacity);
        Console.WriteLine("Capacity of String builder 2 :" + sb2.Capacity);
        Console.WriteLine("Capacity of String builder 3 :" + sb3.Capacity);
        Console.WriteLine("Capacity of String builder 4 :" + sb4.Capacity);

        sb4.Remove(4, 4);
        Console.WriteLine("String builder 4 after remove is:" + sb4);

        Console.WriteLine();
        string str = sb4.ToString();
        Console.WriteLine("Entraced String is :" + str);
    }
}