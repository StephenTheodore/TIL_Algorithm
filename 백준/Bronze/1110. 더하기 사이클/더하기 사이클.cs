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
            String tmp;
            String str;
            int cnt = 0;

            str = sr.ReadLine();
            if (int.Parse(str) < 10)
                str += "0";
            tmp = str;
            while(true)
            {
                str = str[1].ToString() + ((int.Parse(str[0].ToString()) + int.Parse(str[1].ToString()))%10).ToString();
                cnt++;
                if (int.Parse(tmp) == int.Parse(str))
                    break;
            }
            Console.WriteLine(cnt);
        }
    }
}