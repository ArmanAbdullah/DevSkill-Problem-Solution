using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_184
    {
        static void Main()
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n+1];
                arr[0] = 1;
                arr[1] = 3;
    
            for (int i = 2; i < n; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }
                Console.WriteLine(arr[n-1]);
                    test--;
            }
        }
    }
}
