using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_20
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            String[] cases= new String[test];
            int i = 0;
            
            for(;i<test;i++)
            {
                int x1=0, y1=0, x2=0, y2=0;
                double r=0,r1=0;
                var line1 = Console.ReadLine();
                var part = line1.Split(' ');
                x1 = Convert.ToInt32(part[0]);
                y1 = Convert.ToInt32(part[1]);
                r = Convert.ToDouble(part[2]);
                x2 = Convert.ToInt32(part[3]);
                y2 = Convert.ToInt32(part[4]);
                r1 = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
                if (r < r1)
                {
                    cases[i] = "Outside";
                }
                else if (r > r1)
                {
                    cases[i] = "Inside";
                }
                else
                    cases[i] = "OnCircle";
            }

            for(int j = 0; j < cases.Length; j++)
            {
                Console.WriteLine("Case {0}: {1}",j+1,cases[j]);
            }


        }
    }
}
