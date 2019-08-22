using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_192
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            while (test >= m)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                ulong count1=long.MaxValue;
                ulong count2 = long.MaxValue;
                for (; i < n; i++)
                {
                    var input = Console.ReadLine();
                    var part = input.Split(' ');
                    ulong cost = Convert.ToUInt64(part[0]);
                    ulong maintain = Convert.ToUInt64(part[1]);
                    if (cost < count1)
                    {
                        count1 = cost;
                        count2 = maintain;
                    }
                    if (cost == count1)
                    {
                        if (maintain < count2)
                        {
                            count1 = cost;
                            count2 = maintain;
                        }
                    }
                }
                Console.WriteLine("Case {0}: {1} {2}",m,count1,count2);
                m++;
            }
        }
    }
}
