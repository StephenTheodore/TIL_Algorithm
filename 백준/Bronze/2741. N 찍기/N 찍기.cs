using System;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            
            for(int i=1; i<=n; i++)
            {
                sb.Append(i.ToString()+"\n");
            }
            Console.Write(sb);
        }
    }
}
