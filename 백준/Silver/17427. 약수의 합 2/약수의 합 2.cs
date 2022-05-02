using System;
using System.IO;

namespace _17472_약수의합2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int N = Convert.ToInt32(sr.ReadLine());
            int cnt;
            long sum = 0;

            for (int i = 1; i <= N; i++)
            {
                cnt = (N / i);
                sum += (cnt * i);
            }
            Console.WriteLine(sum);
        }
    }
}