using System;
using System.IO;
using System.Text;

namespace _10828_스택
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int N = Convert.ToInt32(sr.ReadLine());

            int[] stack = new int[10001];
            int size = 0;

            while (N-- > 0)
            {
                string[] cmd = sr.ReadLine().Split(' ');
                switch(cmd[0])
                {
                    case "push":
                        stack[size++] = Convert.ToInt32(cmd[1]);
                        break;
                    case "pop":
                        if (size == 0)
                            sb.AppendLine("-1");
                        else
                            sb.AppendLine(stack[size-- - 1].ToString());
                        break;
                    case "size":
                        sb.AppendLine(size.ToString());
                        break;
                    case "empty":
                        if (size == 0)
                            sb.AppendLine("1");
                        else
                            sb.AppendLine("0");
                        break;
                    case "top":
                        if (size == 0)
                            sb.AppendLine("-1");
                        else
                            sb.AppendLine(stack[size - 1].ToString());
                        break;
                }
            }
            Console.WriteLine(sb);
        }
    }
}