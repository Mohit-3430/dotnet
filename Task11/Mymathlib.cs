using System;
namespace mymathlib
{
    public class MML
    {
        public static long Add(long x, long y)
        {
            return (x + y);
        }
        public static long Mul(long x, long y)
        {
            return (x * y);
        }
    }
}

// csc /target:library /out:mymathlib.dll .\Mymathlib.cs