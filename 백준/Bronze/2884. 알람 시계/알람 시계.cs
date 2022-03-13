using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] sp = s.Split();
            int H, M;
            H = int.Parse(sp[0]);
            M = int.Parse(sp[1]);

            if (M >= 45)
                M -= 45;
            else
            {
                if (H == 0)
                    H = 24;
                H -= 1;
                M = M + 15;
            }
            M %= 60;
            
            Console.WriteLine(H + " " + M);
        }

    }
}
