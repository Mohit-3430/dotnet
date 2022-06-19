using System;
using System.Threading;

class CreateThreadDemo{
    public static void Main(string[] a){
        ThreadStart ts = new ThreadStart(childThread);
        Console.WriteLine("Creating the child thread from the main function");
        Thread t = new Thread(ts);
        t.Start();

    }
    public static void childThread(){
        Console.WriteLine("Child Thread created!!");
    }
}