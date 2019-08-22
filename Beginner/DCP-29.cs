using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_29
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            int m = 0;
            while (test > m)
            {
                string input = Console.ReadLine();
                var full = input.Split(' ');
                
                //char[] cha1 = full[0].ToCharArray();
                //char[] cha2 = full[1].ToCharArray();
                int maxlength = LongestCommonSubstring(full[0],full[1]);
                Console.WriteLine("Case {0}: {1}",m+1,maxlength);
                m++;
            }


        }
        static int LongestCommonSubstring(string str1, string str2)
        {
            if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
                return 0;

            int[,] num = new int[str1.Length, str2.Length];
            int maxlen = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] != str2[j])
                        num[i, j] = 0;
                    else
                    {
                        if ((i == 0) || (j == 0))
                            num[i, j] = 1;
                        else
                            num[i, j] = 1 + num[i - 1, j - 1];

                        if (num[i, j] > maxlen)
                        {
                            maxlen = num[i, j];
                        }
                    }
                }
            }
            return maxlen;
        }
    }
}
