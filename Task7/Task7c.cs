using System;
using System.Threading;

class DeleteDemo
{
    public static void Main(string[] a)
    {
        ThreadStart ts = new ThreadStart(childThread);
        Console.WriteLine("Creating the child thread from the main function");
        Thread t = new Thread(ts);
        t.Start();
        Thread.Sleep(4000);
        Console.WriteLine("Aborting the thread");
        t.Abort();

    }
    public static void childThread()
    {
        Console.WriteLine("Child Thread started!!");

        try
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(450);
                Console.WriteLine(i + "");
            }
            Console.WriteLine("Child Thread Completed");
        }
        catch (ThreadAbortException e)
        {
            Console.WriteLine("Caught Thread Abort Exception");
        }
        finally
        {
            Console.WriteLine("Thread exception finally caught");
        }
    }
}