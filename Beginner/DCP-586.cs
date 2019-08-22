using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_586
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                var input = Console.ReadLine();
                var part = input.Split(' ');
                int BronzeMedalCount = Convert.ToInt32(part[0]);
                int SilverMedalCount = Convert.ToInt32(part[1]);
                int GoldMedalCount = Convert.ToInt32(part[2]);

                int scoreFromMedals = (BronzeMedalCount * 10) + (SilverMedalCount * 50) + (GoldMedalCount * 100);
                Console.WriteLine(scoreFromMedals);
                test--;
            }
        }
    }
}
