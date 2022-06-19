using System;

public class StringDemo
{
    public static void Main(string[] a)
    {
        Console.WriteLine("Enter a string");
        string str1 = Console.ReadLine();
        Console.WriteLine("The length of string is:" + str1.Length);
        string str2 = " string_2";
        Console.WriteLine("Concatenated Strings:");
        Console.WriteLine(string.Concat(str1, str2));
        Console.WriteLine("Other way to Concatenate Strings:");
        Console.WriteLine(str1 + str2);

        Console.WriteLine("Comparing two strings:");
        if (str1.Equals(str2))
        {
            Console.WriteLine("The two strings are similar");
        }
        else
        {
            Console.WriteLine("The two strings are different");
        }

        string str3 = "A_String";
        Console.WriteLine("Using Padleft and padRight:");
        Console.WriteLine(str1.PadLeft(' '));
        Console.WriteLine(str2.PadRight(' '));

        string str4 = "   A String    ";
        Console.WriteLine("Performing the trim operation");
        Console.WriteLine(str4.Trim());
    }
}