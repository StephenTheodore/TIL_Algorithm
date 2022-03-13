using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] sp = s.Split();
            double a = double.Parse(sp[0]);
            double b = double.Parse(sp[1]);
            Console.WriteLine(sum(a, b));
            Console.WriteLine(sub(a, b));
            Console.WriteLine(mul(a, b));
            Console.WriteLine((int)div(a, b));
            Console.WriteLine(mod(a, b));
        }
        public static double sum(double a, double b)
        {
            return a + b;
        }
        public static double sub(double a, double b)
        {
            return a - b;
        }
        public static double mul(double a, double b)
        {
            return a * b;
        }
        public static double div(double a, double b)
        {
            return a / b;
        }
        public static double mod(double a, double b)
        {
            return a % b;
        }
    }
}
