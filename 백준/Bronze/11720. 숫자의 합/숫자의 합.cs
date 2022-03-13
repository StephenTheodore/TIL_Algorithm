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
            String s = sr.ReadLine();

            int sum = 0;

            for(int i=0; i<n; i++)
            {
                sum += int.Parse(s[i].ToString());
            }

            Console.WriteLine(sum);
        }
    }
}