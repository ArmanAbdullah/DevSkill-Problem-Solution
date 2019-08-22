using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_262
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int m = n;
                int[] arr = new int[100000];
                int i;
                for ( i = 0; m > 0; i++)
                {
                    arr[i] = m % 2;
                    m = m / 2;
                }
                Console.Write(n+" ");
                int p = i - 1;
                if (n >= 0 && n <= 2 && n!=1)
                {
                    for (i = 2; i >= 0; i--)
                    {
                        Console.Write(arr[i]);
                    }
                }
                else if (n == 1)
                {
                    Console.Write("0"); Console.Write("0"); Console.Write("0");
                }
                else
                {
                    //for (i = p; i >= (p-2); i--)
                    //{

                    //    Console.Write(arr[i]);
                    //}
                    Console.Write("1");Console.Write("1");Console.Write("0");
                }
                Console.Write("\n");
                test--;
            }
        }
    }
}
