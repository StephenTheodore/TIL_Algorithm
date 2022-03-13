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
            int Destination = int.Parse(sr.ReadLine());
            
            Console.WriteLine(TheBeeHive(Destination));
        }
        static int TheBeeHive(int Destination)
        {
            int Count = 0;
            int Path = 1;

            while(true)
            {
                if (Path + (Count * 6) < Destination)
                {
                    Path += Count * 6;
                    Count++;
                }
                else
                {
                    Count++;
                    break;
                }
            }

            return Count;
        }
    }
}