using System;
class C1{

    private int x1 =5;
    public int x2 = 10;
    protected int x3 = 15;
    public void displayX(){
        Console.WriteLine("The contents of X class:");
        Console.WriteLine("The value of x1 :" + x1);
        Console.WriteLine("The value of x2 :" + x2);
        Console.WriteLine("The value of x3 :" + x3);
    }
}

class C2 :  C1 {
    public int y1 = 3;
    public void displayY(){
        Console.WriteLine("The contents of Y class:");
        // Console.WriteLine("The value of a is: " + base.a);
        Console.WriteLine("The value of x2 is: " + base.x2);
        Console.WriteLine("The value of x3 :" + base.x3);
        Console.WriteLine("The value of y1 is: " + y1);
    }
}

class Modifiers{
    public static void Main(string[] args){
        C1 xob = new C1();
        xob.displayX();
        Console.WriteLine();
        C2 yob = new C2();
        yob.displayY();
    }
}