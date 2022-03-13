using System;
using System.Text;
using System.IO;

namespace MooYaHo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int N = int.Parse(sr.ReadLine());
            String s = sr.ReadLine();

            Console.WriteLine(Is_Prime(s, N));
        }
        static int Is_Prime(String s, int N)
        {
            int ret = 0;
            int max = 0;
            int[] PrimeNum;
            String[] arr = s.Split();

            for(int i = 0; i < arr.Length; i++)
            {
                if (int.Parse(arr[i]) > max)
                    max = int.Parse(arr[i]);
            }

            PrimeNum = new int[max + 1];
            for (int i = 1; i < PrimeNum.Length; i++)
            {
                if (PrimeNum[i] == 1)
                    continue;
                else
                {
                    int count = 0;
                    for (int j = 1; j < i + 1; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }
                    if (count == 2)
                    {
                        PrimeNum[i] = 2;
                        for (int k = 2; k < max; k++)
                        {
                            if (i * k > N)
                                break;
                            PrimeNum[i * k] = 1;
                        }
                        continue;
                    }
                    PrimeNum[i] = 1;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (PrimeNum[int.Parse(arr[i])] == 2)
                    ret++;
            }
            return ret;
        }
    }
}