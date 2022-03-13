using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] sp = s.Split();
            Console.Write(sum(int.Parse(sp[0]), int.Parse(sp[1])));
        }
        public static int sum(int a, int b)
        {
            return a + b;
        }
    }
}
