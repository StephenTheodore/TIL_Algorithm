using System;
using System.Text;
using System.IO;

namespace _2869
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            String[] s = sr.ReadLine().Split();

            Console.WriteLine(Sum(s[0].ToCharArray(), s[1].ToCharArray()));
        }
        static String Sum(Char[] V1, Char[] V2)
        {
            int L1 = V1.Length, L2 = V2.Length;
            int n1, n2;
            int i;
            Char[] ret;

            Array.Reverse(V1);
            Array.Reverse(V2);

            if(L1 > L2)
            {
                ret = new Char[L1 + 1];
                for(i = 0; i < L2; i++)
                {
                    n1 = V1[i] - '0';
                    n2 = V2[i] - '0';
                    if (n1 + n2 >= 10)
                        ret[i + 1]++;
                    n1 = 48 + (n1 + n2) % 10;
                    n1 = ret[i] + n1;
                    ret[i] = (Char)n1;
                    if (ret[i] == ':')
                    {
                        ret[i] = '0';
                        ret[i + 1]++;
                    }
                }

                for(i = L2; i < L1; i++)
                {
                    n1 = ret[i];
                    n2 = V1[i] - '0';
                    if (n1 + n2 >= 10)
                        ret[i + 1]++;
                    n1 = 48 + (n1 + n2) % 10;
                    ret[i] = (Char)n1;
                }
            }
            else
            {
                ret = new Char[L2 + 1];
                for (i = 0; i < L1; i++)
                {
                    n1 = V1[i] - '0';
                    n2 = V2[i] - '0';
                    if (n1 + n2 >= 10)
                        ret[i + 1]++;
                    n1 = 48 + (n1 + n2) % 10;
                    n1 = ret[i] + n1;
                    ret[i] = (Char)n1;
                    if (ret[i] == ':')
                    {
                        ret[i] = '0';
                        ret[i + 1]++;
                    }
                }

                for (i = L1; i < L2; i++)
                {
                    n1 = ret[i];
                    n2 = V2[i] - '0';
                    if (n1 + n2 >= 10)
                        ret[i + 1]++;
                    n1 = 48 + (n1 + n2) % 10;
                    ret[i] = (Char)n1;
                }
            }
            Array.Reverse(ret);
            if (ret[0] == 1)
                ret[0] = '1';
            else if(ret[0] == '\0')
                ret[0] = (Char)32;
            return String.Concat(ret).Trim();
        }
    }
}
