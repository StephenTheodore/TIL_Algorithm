using System;
using System.Text;
using System.IO;

namespace _2869
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            Int32 T = Int32.Parse(sr.ReadLine());

            for(int i = 0; i < T; i++)
            {
                Int32 k = Int32.Parse(sr.ReadLine());
                Int32 n = Int32.Parse(sr.ReadLine());
                Console.WriteLine(Resident(k, n));
            }
        }
        static Int32 Resident(Int32 k, Int32 n)
        {
            Int32[,] Apartment = new Int32[k + 1, n];

            for(int i = 0; i < k+1; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i == 0)
                    {
                        Apartment[i, j] += j + 1;
                    }
                    else if (j == 0)
                        Apartment[i, j] += Apartment[i - 1, j];
                    else
                        Apartment[i, j] = Apartment[i, j] + Apartment[i, j - 1] + Apartment[i - 1, j];
                }
            }

            return Apartment[k, n-1];
        }
    }
}