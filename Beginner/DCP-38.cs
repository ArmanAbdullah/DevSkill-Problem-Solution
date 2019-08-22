using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_38
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                int friend = Convert.ToInt32(Console.ReadLine());
                var dictionary = new Dictionary<int, string>();
                //var arr = new int[friend + 1];
                int highest = 0, lowest = int.MaxValue;
                while (friend > 0)
                {
                    var input = Console.ReadLine();
                    var part = input.Split(' ');
                    int time = Convert.ToInt32(part[1]);
                    if (time > highest)
                    {
                        highest = time;
                    }
                    if (time < lowest)
                    {
                        lowest = time;
                    }
                    dictionary.Add(time, part[0]);
                    friend--;
                }

                Console.WriteLine(dictionary[highest] + " " + dictionary[lowest]);
                test--;
            }
        }
    }
}
