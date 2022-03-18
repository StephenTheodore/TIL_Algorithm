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

            Console.WriteLine(Divide(list, N));
        }
        static int Divide(List<int> list, int N)
        {
            var qryResult = from data in list where data == list.Max() select data;
            int max = -1;
            int count;
            while (N > 0)
            {
                max = qryResult.ElementAt(0);
                count = qryResult.Count();
                if (max == 1)
                    return 1;
                if (N <= (list.Count - count) + (count * 2))
                {
                    list.RemoveAll(n => n == max);
                    max = qryResult.ElementAt(0);
                    break;
                }
                for (int i = 0; i < count; i++)
                    list.AddRange(new int[] { max / 2, max - (max / 2) });
                list.RemoveAll(n => n == max);
                N -= count;
            }
            return max;
        }
    }
}