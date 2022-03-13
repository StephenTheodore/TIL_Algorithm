using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = int.Parse(Console.ReadLine());

            for(int i=1; i<=9; i++)
            {
                Console.WriteLine(val + " * " + i + " = " + val * i);
            }
        }

    }
}
