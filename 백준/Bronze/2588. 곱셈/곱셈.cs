using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            int c1, c2, c3;
            c1 = int.Parse(s1) * int.Parse(s2.Substring(2, 1));
            c2 = int.Parse(s1) * int.Parse(s2.Substring(1, 1));
            c3 = int.Parse(s1) * int.Parse(s2.Substring(0, 1));

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c1+c2*10+c3*100);
        }
    }
}
