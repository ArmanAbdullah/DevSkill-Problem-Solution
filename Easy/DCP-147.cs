using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_147
    {
        static void Main(String[] args)
        {
            String input;
            while ((input = Console.ReadLine())!=null)
            {
                ulong n = Convert.ToUInt64(input);
                ulong i, j, k;
                ulong count =0;
                for (i = 3,j=5,k=15; i< n; i += 3,j+=5,k+=15)
                {
                    if(j < n)
                    {
                        count += j;
                    }
                    count += i;
                    if (k < n)
                    {
                        count -= k;
                    }
                    

                }
                Console.WriteLine(count);
            }
        }
    }
}
