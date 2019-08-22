using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_25
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            
            while (test > 0)
            {
                string result = "No";
                string sentence = Console.ReadLine();
                string sen1=sentence.ToUpper();
                char[] charArr = sen1.ToCharArray();

                for (int i = 0; i < charArr.Length; i++)
                {
                    
                    if (charArr[i] != charArr[(charArr.Length - 1) - i])
                    {
                        result = "No";
                        break;
                    }

                    result = "Yes";
                }
                Console.WriteLine(result);
                test--;
            }


        }
    }
}
