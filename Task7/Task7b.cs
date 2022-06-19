using System;
using System.Threading;

class CreateManageDemo
{
    public static void Main(string[] a)
    {
        ThreadStart ts = new ThreadStart(childThread);
        Console.WriteLine("Creating the child thread from the main function");
        Thread t = new Thread(ts);
        t.Start();

    }
    public static void childThread()
    {
        Console.WriteLine("Child Thread started!!");
        int sleepTime = 3000;
        Console.WriteLine("The child thread sleeps for " + (sleepTime / 1000) + " seconds");
        Thread.Sleep(sleepTime);
        Console.WriteLine("Child thread Resumed ...");
    }
}