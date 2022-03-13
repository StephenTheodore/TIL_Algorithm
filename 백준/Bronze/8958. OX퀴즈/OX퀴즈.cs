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
            StringBuilder sb = new StringBuilder();
            String s;
            int winstreak = 0;
            int score = 0;
            int n = int.Parse(sr.ReadLine());
            
            for(int i=0; i<n; i++)
            {
                s = sr.ReadLine();
                for(int j=0; j<s.Length; j++)
                {
                    if (s[j].Equals('O'))
                        score += ++winstreak;
                    else
                        winstreak = 0;
                }
                Console.WriteLine(score);
                winstreak = 0;
                score = 0;
            }


        }
    }
}