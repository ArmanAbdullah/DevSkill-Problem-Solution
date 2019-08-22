using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_210
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                var arr = new long[n + 1];
                
                arr[0] = 0;
                long i = 1;
                for (; i < n; i++)
                {
                    arr[i] = arr[i - 1] +2+ (4 * (i-1));
                }
                Console.WriteLine(arr[n - 1]);
                test--;
                
            }
        }
    }
}
