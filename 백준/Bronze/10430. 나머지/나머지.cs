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
            double c = double.Parse(sp[2]);

            Console.WriteLine((a + b) % c);
            Console.WriteLine(((a%c)+(b%c))%c);
            Console.WriteLine((a*b)%c);
            Console.WriteLine(((a % c) * (b % c)) % c);
        }
    }
}
