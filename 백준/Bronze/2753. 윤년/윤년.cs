using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();

            int year = int.Parse(s1);

            if(year%4 == 0)
            {
                if (year % 400 == 0)
                    Console.WriteLine("1");
                else if (year % 100 != 0)
                    Console.WriteLine("1");
                else
                    Console.WriteLine("0");
            }
            else
                Console.WriteLine("0");
        }
    }
}
