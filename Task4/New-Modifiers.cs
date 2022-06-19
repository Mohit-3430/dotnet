// ### Assembly:
// Put simply, it is the compiled project involving your classes and additional files, if there are. That is, each project in a solution is assembly.

using System;
public class X
{
    int dflt;
    public int pblc;
    private int prvt;
    protected int proctd;
    internal int intrnl;
    protected internal int proc_intrnl;
    public X()
    {
        dflt = 10;
        pblc = 20;
        prvt = 30;
        proctd = 40;
        intrnl = 50;
        proc_intrnl = 60;
    }
    public void pub_show()
    {
        Console.WriteLine("dflt= " + dflt + "pblc= " + pblc + "prvt= " + prvt);
        Console.WriteLine("proctd= " + proctd + "intrnl= " + intrnl + "proc_intrnl=" + proc_intrnl);
    }
    private void priv_show()

    {
        Console.WriteLine("dflt= " + dflt + "pblc= " + pblc + "prvt= " + prvt);
        Console.WriteLine("proctd= " + proctd + "intrnl= " + intrnl + "proc_intrnl=" + proc_intrnl);
    }
    protected void proc_show()
    {
        Console.WriteLine("dflt= " + dflt + "pblc= " + pblc + "prvt= " + prvt);
        Console.WriteLine("proctd= " + proctd + "intrnl= " + intrnl + "proc_intrnl=" + proc_intrnl);
    }
    internal void internal_show()
    {
        Console.WriteLine("dflt= " + dflt + "pblc= " + pblc + "prvt= " + prvt);
        Console.WriteLine("proctd= " + proctd + "intrnl= " + intrnl + "proc_intrnl=" + proc_intrnl);
    }
}
class Y : X
{
    public void show_derived()
    {
        // Console.WriteLine("dflt= " + dflt); ### 'X.dflt' is inaccessible due to its protection level
        Console.WriteLine("pblc= " + pblc);
        //Console.WriteLine("prvt= "+prvt); ### 'X.prvt' is inaccessible due to its protection level
        Console.WriteLine("proctd= " + proctd);
        Console.WriteLine("intrnl= " + intrnl);
        Console.WriteLine("proc_intrnl=" + proc_intrnl);
    }
}
class Z
{
    int f_dflt = 5;

    X xob = new X();
    public void show_nonderived()
    {
        // Console.WriteLine("dflt= " + xob.dflt);
        Console.WriteLine("pblc= " + xob.pblc);
        // Console.WriteLine("prvt= " + xob.prvt);
        // Console.WriteLine("proctd= " + xob.proctd);
        Console.WriteLine("intrnl= " + xob.intrnl);
        Console.WriteLine("proc_intrnl=" + xob.proc_intrnl);
        Console.WriteLine("f_dflt= " + f_dflt);
    }
}
class Access_Demo
{
    public static void Main(string[] n)
    {
        Y y1 = new Y();
        y1.pub_show();
        // y1.priv_show();

        // y1.proc_show();
        y1.internal_show();
        y1.show_derived();
        Z z1 = new Z();
        z1.show_nonderived();
    }
}