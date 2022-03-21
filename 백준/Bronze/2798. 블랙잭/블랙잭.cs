using System;
using System.IO;

namespace _2798
{
    class Program
    {
        static int Max = 0;
        static int N, M;
        static int[] arr;
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            string[] input1 = sr.ReadLine().Split();
            N = Convert.ToInt32(input1[0]);
            M = Convert.ToInt32(input1[1]);

            arr = new int[N];
            string[] input2 = sr.ReadLine().Split();
            for (int i = 0; i < N; i++ )
                arr[i] = Convert.ToInt32(input2[i]);

            for (int i = 0; i < N; i++ )
                DFS(0, arr[i], new int[2] { i, -1 });
             
            Console.WriteLine(Max);
        }
        static void DFS(int deep, int sum, int[] picked)
        {   
            if (Max == M || sum>M)
                return;
            if (deep == 2)
            {
                if (sum <= M && sum > Max)
                    Max = sum;
                return;
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < picked.Length; j++)
                {
                    switch(deep)
                    {
                        case 0:
                            if (picked[0] != i)
                            {
                                picked[1] = i;
                                DFS(deep + 1, sum + arr[i], picked);
                            }
                            break;
                        case 1:
                            if (picked[0] != i && picked[1] != i)
                            {
                                DFS(deep + 1, sum + arr[i], picked);
                                j = 2;
                            }
                            break;
                    }
                }
            }
        }
    }
}