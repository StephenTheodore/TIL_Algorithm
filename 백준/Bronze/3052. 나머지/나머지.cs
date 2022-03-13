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
            int[] mod = new int[42];
            String s;
            int dif = 0;

            for(int i=0; i<10; i++)
            {
                s = sr.ReadLine();
                mod[int.Parse(s) % 42]++;
            }
            for(int i=0; i<42; i++)
            {
                if (mod[i] > 0)
                    dif++;
            }
            Console.Write(dif);
        }
    }
}