using System;
using System.IO;

namespace _2231
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            string N = sr.ReadLine();
            int psdN = int.Parse(N);
            if (psdN > 18)
            {
                for (int i = psdN - (N.Length * 9); i < psdN; i++)
                {
                    if (GetDivsum(i) == N)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < psdN; i++)
                {
                    if (GetDivsum(i) == N)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
            }
            Console.WriteLine(0);
        }
        static string GetDivsum(int num)
        {
            int divsum = num;
            string s = num.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                divsum += Convert.ToInt32(s[i].ToString());
            }
            return divsum.ToString();
        }
    }
}