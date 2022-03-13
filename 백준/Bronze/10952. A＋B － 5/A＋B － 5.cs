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
            String[] str;

            while(true)
            {
                str = sr.ReadLine().Split();
                if (str[0].Equals("0") || str[1].Equals("0"))
                    break;
                Console.WriteLine(int.Parse(str[0]) + int.Parse(str[1]));
            }
        }
    }
}