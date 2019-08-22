using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_26_reverseArray_
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());

            while (test > 0)
            {
                String text = Console.ReadLine();
                String reverse = ReverseArray(text);
                Console.WriteLine(reverse);
                test--;
            }

        }
        public static string ReverseArray(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return (new string(array));
        }

    }
}
