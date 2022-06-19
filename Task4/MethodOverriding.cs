using System;

class P
{
    public void show()
    {
        Console.WriteLine("Inside show method of Parent");
    }
}

class C1 : P
{
    public void show()
    {
        base.show();
        Console.WriteLine("Inside the show method of C1");
    }
}

class C2 : P
{
    public void show()
    {
        base.show();
        Console.WriteLine("Inside the show method of C2");
    }
}

class MethodOverriding
{
    public static void Main(string[] args)
    {
        new C1().show();
        new C2().show();
    }
}