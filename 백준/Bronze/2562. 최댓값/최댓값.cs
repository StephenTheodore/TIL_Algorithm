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
            int max = 0, index = 0;

            String[] arr = new String[9];

            for (int i = 0; i<9; i++)
            {
                arr[i] = sr.ReadLine();
                if (i != 0)
                {
                    if (int.Parse(arr[i]) > max)
                    {
                        max = int.Parse(arr[i]);
                        index = i;
                    }
                }
                else
                {
                    max = int.Parse(arr[i]);
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(index+1);
        }
    }
}