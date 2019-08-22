using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_117
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                ulong n = Convert.ToUInt64(Console.ReadLine());
                ulong sum = (n*(n + 1)) / 2;
                Console.WriteLine(sum);
                test--;
            }
        }
    }
}
