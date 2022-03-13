using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string[] sp = s1.Split();

            if (int.Parse(sp[0]) > int.Parse(sp[1]))
                Console.WriteLine(">");
            else if (int.Parse(sp[0]) < int.Parse(sp[1]))
                Console.WriteLine("<");
            else
                Console.WriteLine("==");
        }
    }
}
