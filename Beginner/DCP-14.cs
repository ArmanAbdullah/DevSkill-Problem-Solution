using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_14
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            double a = 0, b = 0, c = 0, dia = 0;
            while (test > 0)
            {
                var line1 = Console.ReadLine();
                var part1 = line1.Split(' ');
                a = Convert.ToDouble(part1[0]);
                b = Convert.ToDouble(part1[1]);
                c = Convert.ToDouble(part1[2]);
                dia =Math.Sqrt( Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2));
                Console.WriteLine("{0:0.00}", dia);
                test--;
            }
            

        }
    }
}
