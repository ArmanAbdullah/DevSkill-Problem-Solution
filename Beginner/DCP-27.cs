using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_27
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());

            while (test > 0)
            {
                int count = 1;
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 1)
                {
                    for (int i = 2; i <= Math.Sqrt(num); i++)
                    {

                        if ((i != num) && ((num % i) == 0))
                        {
                            count = 0;
                            break;
                        }

                    }
                }
                else
                    count = 0;
                    

                if (count == 1)
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