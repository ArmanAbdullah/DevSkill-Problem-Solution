using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_194
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                long num = Convert.ToInt64(Console.ReadLine());
                double code = num/100000000000;
                if (Math.Floor(code) != 88)
                {
                    num = num + 8800000000000;
                }
                long sim = num / 100000000;
                //Console.WriteLine(sim);
                switch (sim)
                {
                    case 88017:
                        Console.WriteLine("{0} Grameenphone",num);
                        break;
                    case 88011:
                        Console.WriteLine("{0} Citycell", num);
                        break;
                    case 88015:
                        Console.WriteLine("{0} Teletalk", num);
                        break;
                    case 88016:
                        Console.WriteLine("{0} Airtel", num);
                        break;
                    case 88018:
                        Console.WriteLine("{0} Robi", num);
                        break;
                    case 88019:
                        Console.WriteLine("{0} Banglalink", num);
                        break;

                }
                test--;
            }
        }
    }
}
