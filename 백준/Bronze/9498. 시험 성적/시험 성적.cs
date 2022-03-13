using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();

            int score = int.Parse(s1);

            if (score >= 90)
                Console.WriteLine("A");
            else if (score >= 80)
                Console.WriteLine("B");
            else if (score >= 70)
                Console.WriteLine("C");
            else if (score >= 60)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
        }
    }
}
