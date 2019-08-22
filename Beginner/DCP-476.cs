using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_476
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                var input = Console.ReadLine();

                if (input.Equals("ac"))
                {
                    Console.WriteLine("Accepted");
                }
                else if (input.Equals("wa"))
                {
                    Console.WriteLine("Wrong Answer");
                }
                else if (input.Equals("tle"))
                {
                    Console.WriteLine("Time Limit Exceeded");
                }
                else if (input.Equals("rte"))
                {
                    Console.WriteLine("Run Time Error");
                }

                    test--;
                }

        }
    }
}
