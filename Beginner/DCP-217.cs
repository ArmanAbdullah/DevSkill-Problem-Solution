using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_217
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            while (test >= m)
            {
                var input = Console.ReadLine();
                var part = input.Split(' ');
                char[] arr = part[0].ToCharArray();
                //long num = Convert.ToInt64(part[0]);
                int n = Convert.ToInt32(part[1]);
                int i;
                for (i=0;n>0;i++)
                {
                    if (arr[i] == '9')
                    {
                        continue;
                    }
                    else
                    {
                        arr[i] = '9';
                        n--;
                    }
                }
                Console.Write("Case {0}: ",m);
                for (i = 0; i <arr.Length; i++)
                {
                    Console.Write(arr[i]);
                }
                Console.Write("\n");
                m++;
            }
        }
    }
}
