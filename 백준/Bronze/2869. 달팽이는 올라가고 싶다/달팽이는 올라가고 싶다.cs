using System;
using System.Text;
using System.IO;

namespace _2869
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            String[] s = sr.ReadLine().Split();
            double A = double.Parse(s[0]);
            double B = double.Parse(s[1]);
            double V = double.Parse(s[2]);

            Console.WriteLine(Climb(A, B, V));
        }
        static double Climb(double a, double b, double v)
        {
            return 1 + Math.Ceiling((v - a) / (a - b));
        }
    }
}