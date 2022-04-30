using System;
using System.IO;

namespace _1037_약수
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int R = Convert.ToInt32(sr.ReadLine());
            List<int> list = new List<int>();
            list.AddRange(Array.ConvertAll(sr.ReadLine().Split(' '), Convert.ToInt32));
            list.Sort();

            Console.WriteLine(Convert.ToInt32(list[0]) * Convert.ToInt32(list[list.Count() - 1]));
        }
    }
}