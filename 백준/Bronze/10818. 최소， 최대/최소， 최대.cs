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
            int size = int.Parse(sr.ReadLine());
            int max = 0, min = 0;

            String[] arr = sr.ReadLine().Split();

            for (int i = 0; i<size; i++)
            {
                if (i != 0)
                {
                    if (int.Parse(arr[i]) > max)
                        max = int.Parse(arr[i]);
                    if (int.Parse(arr[i]) < min)
                        min = int.Parse(arr[i]);
                }
                else
                {
                    max = int.Parse(arr[i]);
                    min = int.Parse(arr[i]);
                }
            }

            Console.WriteLine(min + " " + max);
        }
    }
}