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
            List<int> list = new List<int>();
            int N = int.Parse(sr.ReadLine());
            for (int i = 0; i < N; i++)
                list.Add(int.Parse(sr.ReadLine()));

            QuickSort(list, 0, N - 1);

            Console.WriteLine(string.Join("\n", list));
        }
        static void QuickSort(List<int> list, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(list, start, end);

                QuickSort(list, start, pivot - 1);
                QuickSort(list, pivot, end);
            }
        }
        static int Partition(List<int> list, int start, int end)
        {
            int pivot = list[start];

            while (start <= end)
            {
                while (list[end] > pivot)
                    end--;
                while (list[start] < pivot)
                    start++;

                if (start <= end)
                    Swap(list, start++, end--);
                    
            }
            return start;
        }
        static void Swap(List<int> list, int idx1, int idx2)
        {
            int tmp = list[idx1];
            list[idx1] = list[idx2];
            list[idx2] = tmp;
        }
    }
}