using System;
using System.Text;
using System.IO;

namespace MooYaHo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int Order = int.Parse(sr.ReadLine());

            Console.WriteLine(Find_Target(Order));
        }
        static String Find_Target(int Ordinal)
        {
            int cur = 1;
            int x, y;

            while(Ordinal - cur > 0)
            {
                Ordinal -= cur++;
            }
            if (cur%2 == 1)
            {
                cur++;
                x = cur - Ordinal;
                y = cur - x;
            }
            else
            {
                cur++;
                y = cur - Ordinal;
                x = cur - y;
            }

            return string.Format("{0:D}/{1:D}", x, y);
        }
    }
}