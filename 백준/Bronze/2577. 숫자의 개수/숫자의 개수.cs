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
            int[] used = new int[10];
            String result;
            int mul = 1;
            
            for(int i=0; i<3; i++)
            {
                mul *= int.Parse(sr.ReadLine());
            }
            
            result = mul.ToString();

            for (int i = 0; i<result.Length; i++)
            {
                used[int.Parse(result[i].ToString())]++;
            }
            for(int i=0; i<10; i++)
            {
                Console.WriteLine(used[i]);
            }
        }
    }
}