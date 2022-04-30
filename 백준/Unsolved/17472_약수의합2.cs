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

            long[] G = new long[N + 1];
            bool[] P = new bool[N + 1];
            Array.Fill(P, true);
            P[0] = false;
            P[1] = false;
            for (int i = 2; i < P.Length; i++)
            {
                if (P[i] == true)
                {
                    for (int j = i + i; j <= N; j += i)
                    {
                        P[j] = false;
                    }
                }
            }

            for (int i = 2; i <= N; i++)
            {
                if (P[i] == true)
                {
                    G[i] = i;
                    Console.WriteLine("{0} => Value is {0}", i);
                }
                else
                {
                    Console.Write("{0} => (", i);
                    for (int j = i / 2, n = 1; j > 1; j--)
                    {
                        if (i % j == 0 && n % j != 0 && n * j <= i)
                        {
                            n *= j;
                            G[i] += G[j];
                            Console.Write("{0}={1} ,", j, G[j]);
                        }
                        if (n == i)
                            break;
                    }
                    G[i] += i;
                    Console.WriteLine("{0}), Value is {1}", i, G[i]);
                }
            }
            foreach (long val in G)
                Console.WriteLine(val);
            Console.WriteLine("Ans = " + (G.Sum() + N));
        }
    }
}