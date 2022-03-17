using System;
using System.IO;
using System.Text;

namespace _2751
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(sr.ReadLine());

            Heap heap = new Heap(N);
            for (int i = 0; i < N; i++)
                heap.InsertData(int.Parse(sr.ReadLine()));
            for (int i = 0; i < N; i++)
                sb.Append(heap.ReturnData() + "\n");
            Console.Write(sb);
        }
        class Heap
        {
            private int[] datas;
            private int count;
            public Heap(int maxSize)
            {
                count = 0;
                datas = new int[maxSize + 1];
            }
            public void InsertData(int data)
            {
                int idx = ++count;

                while(idx!=1 && data < datas[idx/2])
                {
                    datas[idx] = datas[idx / 2];
                    idx = idx / 2;
                }

                datas[idx] = data;
            }
            public int ReturnData()
            {
                int root = datas[1];
                int parent = 1;
                int child = 2;

                if (count == 2)
                {
                    if (datas[1] < datas[2])
                        SwapData(1, 2);
                    count--;
                    return datas[2];
                }

                SwapData(parent, count--);

                while(child < count)
                {
                    if (datas[child] < datas[child + 1])
                    {
                        if (datas[child] > datas[parent])
                            break;
                        SwapData(parent, child);
                    }
                    else
                    {
                        if (datas[child + 1] > datas[parent])
                            break;
                        SwapData(parent, ++child);
                    }
                    parent = child;
                    child *= 2;
                }

                return root;
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