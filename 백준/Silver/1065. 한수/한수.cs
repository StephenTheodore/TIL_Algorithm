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

            int num = int.Parse(sr.ReadLine());
            Console.WriteLine(HansuYa(num));
        }
        static int HansuYa(int num)
        {
            int cnt = 0;
            String s;
            for (int i = 1; i <= num; i++)
            {
                s = i.ToString();
                if (i >= 1000)
                    break;
                else if (i < 100)
                    cnt++;
                else if (i < 1000)
                {
                    if (s[0] - s[1] == s[1] - s[2])
                        cnt++;
                }
            }
            return cnt;
        }
    }
}