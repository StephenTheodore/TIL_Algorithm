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

            String[] s = sr.ReadLine().Split();
            char[] c;

            c = s[0].ToCharArray();
            Array.Reverse(c);
            s[0] = new String(c);
            c = s[1].ToCharArray();
            Array.Reverse(c);
            s[1] = new String(c);

            if(int.Parse(s[0]) > int.Parse(s[1]))
                Console.WriteLine(s[0]);
            else
                Console.WriteLine(s[1]);
        }
    }
}
