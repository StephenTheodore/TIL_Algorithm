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
            String[] s = sr.ReadLine().Split();

            double max = 0;
            double sum = 0;

            for(int i=0; i<n; i++)
            {
                if(double.Parse(s[i].ToString()) > max)
                    max = double.Parse(s[i].ToString());
            }
            for(int i=0; i<n; i++)
            {
                double tmp = double.Parse(s[i].ToString());
                s[i] = ((tmp / max) * 100).ToString();
                sum += double.Parse(s[i]);
            }
            Console.Write(sum / n);
        }
    }
}