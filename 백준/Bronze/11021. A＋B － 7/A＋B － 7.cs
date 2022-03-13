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
            String[] str;

            for (int i = 0; i < n; i++)
            {
                str = sr.ReadLine().Split();
                sb.Append("Case #" + (i + 1) + ": " + (int.Parse(str[0]) + int.Parse(str[1])) + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}