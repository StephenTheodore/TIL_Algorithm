using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] sp;
            int n = int.Parse(s);

            for (int i=0; i<n; i++)
            {
                s = Console.ReadLine();
                sp = s.Split();
                Console.WriteLine(int.Parse(sp[0]) + int.Parse(sp[1]));
            }
        }

    }
}
