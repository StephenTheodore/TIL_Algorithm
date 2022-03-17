using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace _2792
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            string[] input = sr.ReadLine().Split();
            int N = Convert.ToInt32(input[0]);
            int M = Convert.ToInt32(input[1]);

            Jewel[] colors = new Jewel[M];

            for (int i = 0; i < Convert.ToInt32(M); i++ )
            {
                colors[i] = new Jewel(Convert.ToInt32(sr.ReadLine()));
            }


            Console.Write(sb);
        }
        class Jewel
        {
            public List<int> count;
            public int max;
            public Jewel(int value)
            {
                max = value;
                count = new List<int>();
            }
            public void Divide()
            {
                int a,b;
                a = count[0] / 2;
                b = count[0] - a;
                count.RemoveAt(0);
                count.Add(b);
                count.Add(a);
            }
        }
    }
}