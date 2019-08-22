using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_69
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                var input = Console.ReadLine();
                var part = input.Split(' ');
                int[] arr = new int[n + 1];
                int count1=0,count2=0;
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(part[i]);
                    count1 += arr[i];
                    int cat = arr[i] - i;
                    if (cat < 0)
                        cat = 0;
                    count2 += cat;

                }
                Console.WriteLine(count1-count2);
                test--;
            }
        }
    }
}
