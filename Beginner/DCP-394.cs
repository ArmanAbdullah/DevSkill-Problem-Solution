using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_394
    {
        static void Main(String[] args)
        {


            var input="0";
            while ((input = Console.ReadLine())!=null) {
                int i;
                for (i = 1; i < input.Length; i++)
                {
                    Console.Write('9');
                }
                Console.Write('8');
                for (i = 1; i < input.Length; i++)
                {
                    Console.Write('0');
                }
                Console.Write('1');
                Console.Write('\n');
            }   
            
        }
    }
}
