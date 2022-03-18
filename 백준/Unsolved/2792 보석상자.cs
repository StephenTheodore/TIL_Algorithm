using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _2792
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            
            string[] input = sr.ReadLine().Split();
            int N = Convert.ToInt32(input[0]);
            int M = Convert.ToInt32(input[1]);
            List<int> list = new List<int>();

            for (int i = 0; i < Convert.ToInt32(M); i++ )
                list.Add(Convert.ToInt32(sr.ReadLine()));

            for (int i = 0; i < N; i++)
                Divide(list);

            Console.WriteLine(list.Max());
        }
        static void Divide(List<int> list)
        {
            int max = list.Max();
            int[] value = new int[2];
            value[0] = max / 2;
            value[1] = max - value[0];
            list.AddRange(value);
            list.Remove(max);
        }
    }
}