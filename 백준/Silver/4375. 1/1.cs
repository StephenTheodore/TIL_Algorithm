using System;
using System.IO;

namespace _4375_ones
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string input;
            int N;

            while(true)
            {
                input = sr.ReadLine();
                if (input == "" || input == null)
                    break;

                N = Convert.ToInt32(input);
                if (N % 2 == 0 || N % 5 == 0)
                    continue;
                
                for(long i = 1, M = 0; i <= N; i++)
                {
                    if (++M % N == 0)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    M %= N;
                    M *= 10;
                }
            }
        }
    }
}