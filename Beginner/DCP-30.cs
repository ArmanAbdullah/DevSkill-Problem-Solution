using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_30
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            int m=0;
            while (test > m)
            {
                int i = 0;
                String input = Console.ReadLine();
                char[] chars = input.ToCharArray();
                Array.Sort(chars);
                Console.WriteLine("Case {0}:",m+1);
                for (i = 0; i < chars.Length; i++)
                {
                    int count = 0;
                    for (int j= chars.Length- 1;j>i;j--)
                    {
                        if (chars[i] == chars[j])
                        {
                            count++;
                            chars = new string(chars).Remove(j, 1).ToCharArray();
                            
                        }
                        //input = chars.ToString();
                        //Console.WriteLine(chars.Length);
                    }
                    //Console.WriteLine("{0} {1}",chars[i],count);
                    //Console.WriteLine("{0} {1}",chars[i],count+1);
                    Console.WriteLine("{0} {1}",chars[i],count+1);
                }
                m++;
            }


        }
    }
}
