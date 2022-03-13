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

            bool[] b = new bool[10001];
            int ret;

            for (int i = 1; i < 10001; i++)
            {
                ret = SelfNumber(i);

                if (ret < 10001)
                    b[ret] = true;
            }

            for(int i = 1; i < 10001; i++)
            {
                if (b[i] == false)
                    Console.WriteLine(i);
            }
        }
        static int SelfNumber(int num)
        {
            int sum=num;
            while(true)
            {
                if (num == 0)
                    break;
                else
                {
                    sum += num % 10;
                    num /= 10;
                }
            }
            return sum;
        }
    }
}