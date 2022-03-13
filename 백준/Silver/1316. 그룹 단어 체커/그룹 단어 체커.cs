using System;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int n = int.Parse(sr.ReadLine());
            String s;
            int cnt = 0;

            for(int i=0; i<n; i++)
            {
                s = sr.ReadLine();
                if (IsContinuedText(s))
                    cnt++;
            }
            Console.WriteLine(cnt);
        }
        static bool IsContinuedText(string s)
        {
            int[] jud = new int[26];
            char c = s[0];
            jud[c - 97]++;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                    continue;
                else
                {
                    c = s[i];
                    jud[c - 97]++;
                }
                if (jud[c - 97] > 1)
                    return false;
            }
            return true;
        }
    }
}