using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_74
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            int m = 0;
            while (test > m)
            {
                long p = Convert.ToInt64(Console.ReadLine());
                long n = p - 1;
                if(n%2==0)
                Console.WriteLine("Case #{0}: {1} {2} {3}",m+1, (3*n)+1,(3*n)+2,(3*n)+3);
                else
                    Console.WriteLine("Case #{0}: {3} {2} {1}", m + 1, (3 * n)+1, (3 * n) + 2, (3 * n) + 3);
                m++;
            }
        }
    }
}
