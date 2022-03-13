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

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j < n - 1)
                        sb.Append(" ");
                    else
                        sb.Append("*");
                }
                sb.Append("\n");
            }
            Console.WriteLine(sb);
        }
    }
}