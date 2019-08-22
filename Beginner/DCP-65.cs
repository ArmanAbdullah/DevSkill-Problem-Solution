using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_65
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                int s = Convert.ToInt32(Console.ReadLine());
                double n = Math.Ceiling((Math.Sqrt((8 * s) + 1.0) - 1.0) / 2.0);
                Console.WriteLine(n);
                test--;
            }
        }
    }
}
