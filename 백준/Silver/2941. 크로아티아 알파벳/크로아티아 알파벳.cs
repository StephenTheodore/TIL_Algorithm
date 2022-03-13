using System;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            String s = sr.ReadLine();
            sb.Append(s);

            String[] croatia = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
            int cnt = 0;

            for (int i = 0; i < croatia.Length; i++)
            {
                while (s.Contains(croatia[i]))
                {
                    //s = s.Remove(s.IndexOf(croatia[i]), croatia[i].Length);
                    s = sb.Replace(croatia[i], "0", s.IndexOf(croatia[i]), croatia[i].Length).ToString();
                    cnt++;
                }
            }
            for (int i = 0; i < s.Length; i++)
                if(s[i] != '0')
                    cnt++;
            Console.WriteLine(cnt);
        }
    }
}