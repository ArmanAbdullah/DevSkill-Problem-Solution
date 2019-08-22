using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_443
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            while (test >= m)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                //int[] arr1 = new int[n + 1];
                //int[] arr2 = new int[n + 1];
                //arr1[0] = 0;
                //arr2[0] = 1;
                //for(int i = 1; i <= n; i++)
                //{
                //    arr1[i] = arr1[i-1]+i;
                //    arr2[i] = arr2[i - 1]*i;
                //}
                //if (arr1[n] == arr2[n])

                if(n==1||n==3)
                {
                    Console.WriteLine("Case {0}-> YES;", m);
                }
                else
                    Console.WriteLine("Case {0}-> NO;", m);
                //Console.WriteLine(arr1[n]);
                //Console.WriteLine(arr2[n]);
                m++;
            }
        }
    }
}
