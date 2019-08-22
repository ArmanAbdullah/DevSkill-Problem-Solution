using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_254
    {
        static void Main(String[] args)
        {
            int player = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            int[] score = new int[player + 1];
            while (player >= m)
            {
                var input = Console.ReadLine();
                var part = input.Split(' ');
                int blue = Convert.ToInt32(part[0]);
                int silver = Convert.ToInt32(part[1]);
                int gold = Convert.ToInt32(part[2]);
                int red = Convert.ToInt32(part[3]);
                int total = blue + (silver * 3) + (gold * 10) + (red * (-5));
                if(total>0)
                    Console.WriteLine("Player {0}: {1}",m,total);
                else
                    Console.WriteLine("Player {0}: 0", m);
                score[m - 1] = total;
                m++;
            }
            int count = score[0];
            int i = 1;
            for (; i < player; i++)
            {
                if (score[i] > count)
                {
                    count = score[i];
                }
            }
            Console.WriteLine("High Score = {0}",count);

        }
    }
}
