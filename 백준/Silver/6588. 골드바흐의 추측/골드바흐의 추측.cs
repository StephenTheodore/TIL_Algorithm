using System;
using System.IO;
using System.Collections.Generic;

namespace _6588
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            bool[] noOP = new bool[1000001];
            List<int> oddPrimes = new List<int>();

            int mult = -1;
            for (int i = 2; i <= 1000000; i++)
            {
                if (noOP[i] == false)
                {
                    if (i == 2)
                        mult = 1;
                    else
                    {
                        mult = 2;
                        oddPrimes.Add(i);
                    }
                    while (mult * i < noOP.Length)
                        noOP[i * mult++] = true;
                }
            }
            int n = 0;
            while (true)
            {
                n = Convert.ToInt32(sr.ReadLine());
                if (n == 0)
                    break;
                else
                {
                    for (int i = 0; i < oddPrimes.Count; i++)
                    {
                        if (noOP[n - oddPrimes[i]] == false)
                        {
                            Console.WriteLine("{0} = {1} + {2}", n, oddPrimes[i], n - oddPrimes[i]);
                            break;
                        }
                        if (i == oddPrimes.Count - 1)
                            Console.WriteLine("Goldbach's conjecture is wrong.");
                    }
                }
            }
        }
    }
}