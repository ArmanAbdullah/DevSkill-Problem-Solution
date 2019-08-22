using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_439
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            while (test >= m)
            {
                int k = 0;
                bool b = false;
                int len = Convert.ToInt32(Console.ReadLine());
                var input = Console.ReadLine();
                char[] arr = input.ToCharArray();
                for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u')
                    { b = true;
                        if (i == len - 1)
                            ++k;
                            
                    }
                    
                    if(!(arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u') && b)
                    {
                        ++k;
                        b = false;
                    }
                }
                if (arr.Length == k)
                    k = 0;
                Console.WriteLine("Case {0}: {1}",m,k);
                m++;
            }
        }
    }
}
