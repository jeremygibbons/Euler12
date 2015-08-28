using System;
using System.Collections.Generic;

namespace Euler12
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            uint.TryParse(args[0], out n);
            uint i = 1;
            uint p = 1;
            while(NumDividors(i) < n)
            {
                p++;
                i = NthTriangleNumber(p);
            }
            Console.WriteLine(i);
            Console.ReadLine();
        }

        static uint NthTriangleNumber(uint n)
        {
            return n * (n + 1) / 2;
        }

        static int NumDividors(uint n)
        {
            SortedSet<uint> results = new SortedSet<uint>();
            for (uint i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    results.Add(i);
                    results.Add(n / i);
                }
            }
            return results.Count;
        }
    }
}
