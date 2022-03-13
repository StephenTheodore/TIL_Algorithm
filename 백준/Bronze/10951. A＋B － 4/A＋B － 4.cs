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
            String tmp;
            String[] str;

            while(true)
            {
                tmp = sr.ReadLine();
                if (tmp == null)
                    break;
                str = tmp.Split();
                Console.WriteLine(int.Parse(str[0]) + int.Parse(str[1]));
            }
        }
    }
}