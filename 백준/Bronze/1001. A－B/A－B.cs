using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] sp = s.Split();
            Console.Write(sub(int.Parse(sp[0]), int.Parse(sp[1])));
        }
        public static int sub(int a, int b)
        {
            return a - b;
        }
    }
}
