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
            String[] str = sr.ReadLine().Split();
            String[] val = sr.ReadLine().Split();

            for (int i = 0; i < int.Parse(str[0]); i++)
            {
                if (int.Parse(val[i]) < int.Parse(str[1]))
                    sb.Append(val[i] + " ");
            }
            Console.WriteLine(sb);
        }
    }
}