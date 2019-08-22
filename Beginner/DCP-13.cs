using System;

public class Test
{
    public static void Main()
    {

        int T = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < T; i++)

        {
            int ok = 0;
            for (int j = 0; j < 2; j++)
            {
                string s = Console.ReadLine();
                string[] values = s.Split(' ');
                int b1 = int.Parse(values[0]);
                int b2 = int.Parse(values[1]);
                int p1 = int.Parse(values[2]);
                int p2 = int.Parse(values[3]);
                if ((b1 + b2) > (p1 + p2))
                {
                    ok++;
                }
            }
            if (ok == 2)
            {
                Console.WriteLine("Banglawash");
            }
            else
            {
                Console.WriteLine("Miss");
            }
            ok = 0;
        }





    }
}