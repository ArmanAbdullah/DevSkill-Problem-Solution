using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_26
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            
            while (test>0)
            {
                String text = Console.ReadLine();
                String reverse = ReverseSB(text);
                Console.WriteLine(reverse);
                test--;
            }

        }
        public static string ReverseSB(string text)
        {
            
            StringBuilder builder = new StringBuilder(text.Length);
            for (int i = text.Length - 1; i >= 0; i--)
            {
                builder.Append(text[i]);
            }
            return builder.ToString();
        }
    }
}
