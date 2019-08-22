using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_82
    {
        
            // your code goes here
            static void Main(String[] args)
            {
                int test = Convert.ToInt32(Console.ReadLine());
                while (test > 0)
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n >= 120)
                    {
                        Console.WriteLine("Good Boy Sifat");
                    }
                    else
                        Console.WriteLine("Naughty Boy Sifat");
                    test--;
                }
            }
        
    }
}
