using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_221
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            int m = 0;
            while (m < test)
            {
                string input = Console.ReadLine();
                var part = input.Split(' ');
                int[] part1 = new int[part.Length];
                for(int l = 0; l < part.Length; l++)
                {
                    part1[l] = Convert.ToInt32(part[l]);
                }
                int count1 = part1[0];
                int count2 = part1[0];
                for (int i = 0; i < part1.Length; i++)
                {
                    
                    if (part1[i] > count1)
                    {
                        count1 = part1[i];
                    }
                    if (part1[i] < count2)
                    {
                        count2 = part1[i];
                    }
                    
                    
                    //for(int j = part.Length-1; j >= 0; j--)
                    //{
                    //    if (part1[i] > part1[j])
                    //    {
                    //        count1 = part1[i];
                    //    }
                    //    else if (j == i)
                    //        continue;
                    //    else
                    //        break;
                    //}
                }
                Console.WriteLine("Case {0}: Among {1} numbers {2} is maximum and {3} is minimum", m+1,part1.Length,count1,count2);
                m++;
            }
        }
    }
}
