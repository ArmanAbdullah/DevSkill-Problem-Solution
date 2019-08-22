using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_32
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            while (test >= m)
            {
                var input = Console.ReadLine();
                var part = input.Split(' ');
                int x1 = Convert.ToInt32(part[0]);
                int y1 = Convert.ToInt32(part[1]);
                int x2 = Convert.ToInt32(part[2]);
                int y2 = Convert.ToInt32(part[3]);
                int distance = Math.Abs(x2 - x1) + Math.Abs(y2 - y1);
                Console.WriteLine("Case {0}: {1}",m,distance);
                m++;
            }

        }
    }
}
