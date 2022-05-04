using System;
using System.IO;

namespace _6374_To_the_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int N = Convert.ToInt32(sr.ReadLine());
            List<string> num = new List<string>();
            int[,] arr = new int[N + 1, N + 1];
            int maxsum = -127;

            while (num.Count < N * N)
            {
                string[] str = sr.ReadLine().Split(' ');
                if (str[0] != "")
                    num.AddRange(str);
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i+1, j+1] = Convert.ToInt32(num[i * N + j]);
                }
            }

            for (int i = 1; i <= N; i++)
            {
                for (int j = 2; j <= N; j++)
                {
                    arr[i, j] += arr[i, j - 1];
                }
            }
            for (int i = 1; i <= N; i++)
            {
                for (int j = 2; j <= N; j++)
                {
                    arr[j, i] += arr[j - 1, i];
                }
            }

            for (int i = 1; i <= N; ++i)
            {
                for (int j = i; j <= N; ++j)
                {   
                    int last = arr[j, 1] - arr[i - 1, 1];
                    for (int k = 2; k <= N; ++k)
                    {
                        int sum = arr[j, k] - arr[i - 1, k] - arr[j, k - 1] + arr[i - 1, k - 1];
                        last = Math.Max(last + sum, sum);
                        maxsum = Math.Max(maxsum, last);
                    }
                }
            }

            Console.WriteLine(maxsum);
        }
    }
}