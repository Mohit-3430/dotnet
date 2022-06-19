using System;

class Emp
{
    string name;
    int id;
    float sal;

    public Emp(string name, int id, float sal)
    {
        this.name = name;
        this.id = id;
        this.sal = sal;
    }

    public void display()
    {
        Console.Write("| " + name + "\t| ");
        Console.Write(id + "\t|");
        Console.Write(sal + " |");
        Console.WriteLine();
    }
}

class Employee
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of records u want to enter:");
        int n = int.Parse(Console.ReadLine());
        Emp[] eArray = new Emp[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sal:");
            float sal = float.Parse(Console.ReadLine());
            eArray[i] = new Emp(name, id, sal);
        }
        Console.WriteLine("-------------------------");
        Console.WriteLine("| Name\t| Id \t|Salary |");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("-------------------------");
            eArray[i].display();
        }
        Console.WriteLine("-------------------------");
    }
}