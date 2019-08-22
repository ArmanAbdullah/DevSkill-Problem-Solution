using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_167
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            
            int l = 0;
            while (test > l)
            {
                double x = 0;
                int n = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < n; i++)
                {
                    x = x + Math.Pow((i + 1), 3);
                }
                Console.WriteLine("Case {0}: {1}",l+1,x);

                l++;

            }
        }
    }
}
