using System;

public class StringDemo
{
    public static void Main(string[] a)
    {
        Console.WriteLine("Enter a string");
        string str1 = Console.ReadLine();
        Console.WriteLine("The length of string is:" + str1.Length);
        string str2 = "string_2";
        Console.WriteLine("\nConcatenated Strings:");
        Console.WriteLine(string.Concat(str1, str2));
        Console.WriteLine("\nOther way to Concatenate Strings:");
        Console.WriteLine(str1 + str2);

        Console.WriteLine("\nComparing two strings:");
        if (str1.Equals(str2))
        {
            Console.WriteLine("The two strings are similar");
        }
        else
        {
            Console.WriteLine("The two strings are different");
        }

        Console.WriteLine("\nUsing Padleft and padRight:");
        // This method is used to right-aligns the characters in this string by padding them with spaces on the left.
        Console.WriteLine("Pad Left :'{0}'", str1.PadLeft(10));
        // This method is used to left-aligns the characters in this string by padding them with spaces on the right.
        Console.WriteLine("Pad Right :'{0}'", str2.PadRight(10));

        string str3 = "   A String    ";
        Console.WriteLine("\nPerforming the trim operation");
        Console.WriteLine(str3.Trim());
    }
}