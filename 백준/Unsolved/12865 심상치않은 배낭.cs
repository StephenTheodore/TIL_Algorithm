using System;
using System.IO;
using System.Collections.Generic;

namespace _12865_심상치않은배낭
{
    class Program
    {
        static int[] dp = new int[2];
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input1 = sr.ReadLine().Split(' ');
            int N = input1[0];
            int M = input1[1];

            string[] input2;
            int W = 0;
            int V = 0;
            for (int i = 0; i < N; i++)
            {
                input2 = sr.ReadLine().Split(' ');
                W = input2[0];
                V = input2[1];
            }
        }
        static int[] DFS(int weight,int value)
        {
            /*
            dp[Weight][Value]
            물건의 갯수는 영향을 받지 않음
            Weight는 K를 넘을수 없음

            무게와 가치를 Memoization할 것
            각 무게에 대해 DFS, 최대 Value를 반환
            */
        }
    }
}