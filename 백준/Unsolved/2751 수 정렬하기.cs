using System;
using System.IO;
using System.Collections.Generic;

namespace _2751
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            List<string> list = new List<string>();
            int N = int.Parse(sr.ReadLine());
            for (int i = 0; i < N; i++)
                list.Add(sr.ReadLine());


            for (int i = 0; i < N; i++)
                Console.WriteLine(string.Join("\n",list));
        }
        static void QuickSort(List<string> list, int left, int right)
        {
            if(left<right)
            {
            }
        }
        static int Partition(List<string> list, int left, int right)
        {
            int pivot = list[left];

            while(left<right)
            {
                while(pivot < list[right])
                    right--;
                while(pivot > list[left])
                    left++;
            }
        }
    }
}