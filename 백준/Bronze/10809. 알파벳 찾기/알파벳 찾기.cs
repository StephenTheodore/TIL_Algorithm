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

            int[] pop = new int[26];
            String s = sr.ReadLine();

            for(int i = 0; i < 26; i++)
            {
                pop[i] = -1;
            }

            for(int i=0; i<s.Length; i++)
            {
                for(int j=0; j<26; j++)
                {
                    if (s[i] == 97+j)
                    {
                        if(pop[s[i] - 97] > i || pop[s[i] - 97] == -1)
                            pop[s[i] - 97] = i;
                    }
                }
            }

            foreach(int val in pop)
            {
                Console.Write(val+" ");
            }
        }
    }
}