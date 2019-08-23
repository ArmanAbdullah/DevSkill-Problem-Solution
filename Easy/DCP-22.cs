using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DCP_22
    {
        static void Main(String[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test > 0)
            {
                var input = Console.ReadLine();
                var part = input.Split(',');
                long n = Convert.ToInt32(part[0]);
                long b = Convert.ToInt32(part[1]);
                var list = new List<string>();
                //var arr = new int[n + 1];
                //var stack = new Stack<int>();
                int i;
                if (n == 0)
                    list.Add("0");
                for (i = 0; n > 0; i++)
                {
                    //stack.Push(n % b);
                    list.Add(Convert.ToString(n % b));
                    n /= b;
                }
                for (i = list.Count - 1; i >= 0; i--)
                {
                    switch (list[i])
                    {
                        case "10":
                            list[i] = "A";
                            break;
                        case "11":
                            list[i] = "B";
                            break;
                        case "12":
                            list[i] = "C";
                            break;
                        case "13":
                            list[i] = "D";
                            break;
                        case "14":
                            list[i] = "E";
                            break;
                        case "15":
                            list[i] = "F";
                            break;
                        case "16":
                            list[i] = "G";
                            break;
                        case "17":
                            list[i] = "H";
                            break;
                        case "18":
                            list[i] = "I";
                            break;
                        case "19":
                            list[i] = "J";
                            break;
                        case "20":
                            list[i] = "K";
                            break;
                        case "21":
                            list[i] = "L";
                            break;
                        case "22":
                            list[i] = "M";
                            break;
                        case "23":
                            list[i] = "N";
                            break;
                        case "24":
                            list[i] = "O";
                            break;
                        case "25":
                            list[i] = "P";
                            break;
                        case "26":
                            list[i] = "Q";
                            break;
                        case "27":
                            list[i] = "R";
                            break;
                        case "28":
                            list[i] = "S";
                            break;
                        case "29":
                            list[i] = "T";
                            break;
                        case "30":
                            list[i] = "U";
                            break;
                        case "31":
                            list[i] = "V";
                            break;
                        case "32":
                            list[i] = "W";
                            break;
                        case "33":
                            list[i] = "X";
                            break;
                        case "34":
                            list[i] = "Y";
                            break;
                        case "35":
                            list[i] = "Z";
                            break;
                    }
                    Console.Write(list[i]);
                }
                Console.Write("\n");
                test--;
            }
        }
    }
}
