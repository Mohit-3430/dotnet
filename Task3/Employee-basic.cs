using System;

class EmpB
{
    string name;
    int id;
    float sal;

    public EmpB(string name, int id, float sal)
    {
        this.name = name;
        this.id = id;
        this.sal = sal;
    }
    public void display()
    {
        Console.Write(name + "\t " + id + "\t " + sal);
        Console.WriteLine();
    }
}

class EmployeeB
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of records u want to enter:");
        int n = int.Parse(Console.ReadLine());
        EmpB[] eArray = new EmpB[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sal:");
            float sal = float.Parse(Console.ReadLine());
            eArray[i] = new EmpB(name, id, sal);
        }
        Console.WriteLine("\nThe employee details are:");
        Console.WriteLine("Name\t Id\t Salary");
        for (int i = 0; i < n; i++)
        {
            eArray[i].display();
        }
    }
}