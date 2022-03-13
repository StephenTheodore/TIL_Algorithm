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

            int space = 0;
            String[] s = sr.ReadLine().Split();
            if (s[0] == "")
                space++;
            if (s[s.Length-1] == "")
                space++;
            Console.WriteLine(s.Length-space);
        }
    }
}
