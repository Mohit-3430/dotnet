using System;

public class Plindrome
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());
        int number = num;
        int reverse = 0, digit;


        while (num > 0)
        {
            digit = num % 10;
            reverse = (reverse * 10) + digit;
            num = num / 10;
        }

        if (number == reverse)
            Console.WriteLine("{0} is a Palindrome", number);
        else
            Console.WriteLine("{0} is not a Palindrome", number);
    }
}