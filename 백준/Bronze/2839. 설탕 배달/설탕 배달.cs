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
            Int32 N = Int32.Parse(sr.ReadLine());

            Console.WriteLine(Deliver_Sugar(N));
        }
        static Int32 Deliver_Sugar(Int32 N)
        {
            Int32[] list = { 3, 2, 3, 4, 3 };
            if (N < 9)
            {
                switch (N)
                {
                    case 4:
                    case 7:
                        return -1;
                    case 3:
                    case 5:
                        return 1;
                    case 6:
                    case 8:
                        return 2;
                }
            }
            return list[(N - 9) % 5] + (N - 9) / 5;
        }
    }
}