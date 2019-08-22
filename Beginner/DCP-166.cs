using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_166
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            while (test >= m)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int l=0;
                double[] arr1 = new double[n + 1];
                int[] arr2 = new int[n + 1];
                double price = 0;
                double count=0;
                while (n > l)
                {
                    var st1 = Console.ReadLine();
                    var part = st1.Split(' ');
                    arr1[l] = Convert.ToDouble(part[0]);
                    arr2[l] = Convert.ToInt32(part[1]);
                    price += arr1[l]*arr2[l];
                    



                    l++;
                }
                int cash = Convert.ToInt32(Console.ReadLine());
                count = Math.Floor(Convert.ToDouble(cash) - price);
                Console.WriteLine("Case {1}: {0}",count,m);
                //Console.WriteLine(price);
                m++;
            }
        }
    }
}
