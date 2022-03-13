using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] sp = s.Split();
            Console.Write(div(double.Parse(sp[0]), double.Parse(sp[1])));
        }
        public static double div(double a, double b)
        {
            return a / b;
        }
    }
}
