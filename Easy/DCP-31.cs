using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_31
    {
        static void Main(String[] args)
        {
            int k, i, a, b, c, pc, x;
            k = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= k; i++)
            {
                var input = Console.ReadLine();
                var part = input.Split(' ');
                a = Convert.ToInt32(part[0]);
                b = Convert.ToInt32(part[1]);
                c = Convert.ToInt32(part[2]);
                Console.Write(a / b);
                pc = 0;
                Console.Write(".");
                a %= b;
                while (pc < c)
                {
                    a *= 10;
                    x = a / b;
                    a %= b;
                    Console.Write(x);
                    pc++;
                }
                Console.Write("\n");
            }
        }
    }
}
