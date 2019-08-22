using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_562
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                var input = Console.ReadLine();
                var part = input.Split(' ');
                int arg = Convert.ToInt32(part[0]);
                int bra = Convert.ToInt32(part[1]);
                if (arg > bra)
                {
                    Console.WriteLine("Argentina {0} - {1} Brazil",arg,bra);
                }
                else
                    Console.WriteLine("Brazil {0} - {1} Argentina",bra,arg);
                test--;
            }
        }
    }
}
