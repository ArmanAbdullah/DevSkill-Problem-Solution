using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_28
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());

            while (test > 0)
            {
                var input = Console.ReadLine();
                var part = input.Split(' ');
                double r = Convert.ToDouble(part[0]);
                double s = Convert.ToDouble(part[1]);
                r = Convert.ToDouble(String.Format("{0:0.00}", r));
                //s = Convert.ToDouble(String.Format("{0:0.00}", s));
                double c = Convert.ToDouble(String.Format("{0:0.00}", r * Math.Sqrt(2)));
                if (s==c)
                {
                    Console.WriteLine("Yes");
                }
                else
                    Console.WriteLine("No");

                test--;
            }


        }

    }
}
