using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_535
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                string value = Console.ReadLine();
                byte[] ascii = Encoding.ASCII.GetBytes(value);
                int count = 0;
                for(int i = 0; i < ascii.Length; i++)
                {
                    count = count + ascii[i];
                }
                if (count % 20 == 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                    Console.WriteLine("No");
                test--;
            }
        }
    }
}
