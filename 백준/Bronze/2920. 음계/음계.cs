using System;
using System.IO;

namespace _2920_음계
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int[] scale = Array.ConvertAll(sr.ReadLine().Split(' '), s => Convert.ToInt32(s));

            if (scale[0] == 1)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (scale[i] != i + 1)
                    {
                        Console.WriteLine("mixed");
                        return;
                    }
                }
                Console.WriteLine("ascending");
            }
            else if (scale[0] == 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (scale[i] != 8 - i)
                    {
                        Console.WriteLine("mixed");
                        return;
                    }
                }
                Console.WriteLine("descending");
            }
            else
                Console.WriteLine("mixed");
        }
    }
}