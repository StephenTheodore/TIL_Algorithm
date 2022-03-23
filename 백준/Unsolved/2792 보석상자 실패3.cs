using System;
using System.IO;

namespace _2792
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            Heap Jewels = new Heap(N + 1);

            for (int i = 0; i < M; i++)
                Jewels.InsertData(int.Parse(sr.ReadLine()));

            if (Jewels.GetRoot() != 1)
                while (N > M++)
                    Jewels.DivideData();

            Console.WriteLine(Jewels.GetRoot());
        }
        class Heap
        {
            private int[] datas;
            private int count;
            public Heap(long size)
            {
                count = 0;
                datas = new int[size];
            }
            public int GetRoot()
            {
                return datas[1];
            }
            public void InsertData(int data)
            {
                int idx = ++count;

                while (idx != 1 && data > datas[idx / 2])
                {
                    datas[idx] = datas[idx / 2];
                    idx = idx / 2;
                }
                datas[idx] = data;
            }
            public void DivideData()
            {
                int root = datas[1];
                int parent = 1;
                int child = 2;

                datas[1] = 0;
                SwapData(1, count--);

                while(child < count)
                {
                    if (datas[child] > datas[child + 1])
                    {
                        if (datas[child] < datas[parent])
                            break;
                        SwapData(parent, child);
                    }
                    else
                    {
                        if (datas[child + 1] < datas[parent])
                            break;
                        SwapData(parent, ++child);
                    }
                    parent = child;
                    child *= 2;
                }
            }
            private void SwapData(int idx1, int idx2)
            {
                int tmp = datas[idx1];
                datas[idx1] = datas[idx2];
                datas[idx2] = tmp;
            }
        }
    }
}