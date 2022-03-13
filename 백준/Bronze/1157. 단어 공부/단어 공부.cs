using System;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            String s = sr.ReadLine();
            int[] cnt = new int[26];
            int index = 0;
            int max = 0, candidate = 0;

            foreach (char c in s)
            {
                if (c >= 97)
                    cnt[c - 97]++;
                else
                    cnt[c - 65]++;
            }
            for (int i = 0; i < 26; i++)
            {
                if (cnt[i] >= max)
                {
                    candidate = max;
                    max = cnt[i];
                    index = i;
                }
            }
            if (max == candidate)
                Console.WriteLine("?");
            else
                Console.WriteLine((char)(index + 65));
        }
    }
}
