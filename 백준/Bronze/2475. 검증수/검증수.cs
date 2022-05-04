using System;
using System.IO;

namespace _2475_검증수
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int[] num = Array.ConvertAll(sr.ReadLine().Split(' '), s => Convert.ToInt32(s) * Convert.ToInt32(s));

            Console.WriteLine(num.Sum() % 10);
        }
    }
}