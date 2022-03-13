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

            int n = int.Parse(sr.ReadLine());
            String[] s;

            for(int i=0; i<n; i++)
            {
                s = sr.ReadLine().Split();
                for(int j=0; j< s[1].Length; j++)
                {
                    for(int k=0; k< int.Parse(s[0]); k++)
                    {
                        Console.Write(s[1][j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}