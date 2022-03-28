using System;
using System.IO;

namespace _12865_심상치않은배낭
{
    class Program
    {
        static int[,] dp;
        static int N, K, max = 0;
        static int[] W, V;
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input1 = sr.ReadLine().Split(' ');
            string[] input2;
            N = int.Parse(input1[0]) + 1;
            K = int.Parse(input1[1]) + 1;
            W = new int[N];
            V = new int[N];
            dp = new int[N, K];

            for (int i = 1; i < dp.GetLength(0); i++)
            {
                input2 = sr.ReadLine().Split(' ');
                W[i] = int.Parse(input2[0]);
                V[i] = int.Parse(input2[1]);
                PutIn(i, W[i], V[i]);
            }
            Console.WriteLine(max);
        }
        static void PutIn(int amount, int weight, int value)
        {
            for (int i = 0; i < dp.GetLength(1); i++)
            {
                if (i >= weight)
                    dp[amount, i] = Math.Max(dp[amount - 1, i], value + dp[amount - 1, i - weight]);
                else
                    dp[amount, i] = dp[amount - 1, i];
                if (max < dp[amount, i])
                    max = dp[amount, i];
            }
        }
    }
}