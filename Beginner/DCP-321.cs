using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_321
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                var input = Console.ReadLine();
                byte[] ascii = Encoding.ASCII.GetBytes(input);
                int[] ch = new int[ascii.Length];
                for (int i = 0; i < ascii.Length; i++)
                {
                    int val = 32;
                    if (97 <= ascii[i] && ascii[i] <= 122)
                    {
                        
                        ch[i] = Convert.ToInt32(ascii[i]) - val;
                    }
                    else
                        ch[i] = Convert.ToInt32(ascii[i]) + val;

                }
                for (int j = 0; j < ascii.Length; j++)
                {
                    Console.Write("{0}",Convert.ToChar(ch[j]));
                }
                Console.Write("\n");
                    
                test--;
            }
        }
    }
}
