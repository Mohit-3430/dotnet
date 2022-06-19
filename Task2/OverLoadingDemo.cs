using System;

class OverLoadingSample{
    public int add(int n1, int n2){
        return n1+n2;
    }
    public float add(float n1, float n2){
        return n1+n2;
    }
}
public class OverLoadingDemo{
   static void Main(string []args) {
        OverLoadingSample ol = new OverLoadingSample();
        Console.WriteLine("Enter Two Integers: ");
        int i1 = int.Parse(Console.ReadLine());
        int i2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Integer values addition: "+ol.add(i1,i2));

        
        Console.WriteLine("Enter Two Floats: ");
        float f1 = float.Parse(Console.ReadLine());
        float f2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Float values addition: "+ol.add(f1,f2));
   }
}