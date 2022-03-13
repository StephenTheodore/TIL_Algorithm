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
            
            int[] dial = new int[26];
            int sec = 2;


            for(int i = 0; i < 26; i++)
            {
                switch (i+65)
                {
                    case 65:
                    case 68:
                    case 71:
                    case 74:
                    case 77:
                    case 80:
                    case 84:
                    case 87:
                        sec++;
                        dial[i] = sec;
                        break;
                    default:
                        dial[i] = sec;
                        break;
                }
            }
            sec = 0;
            foreach(char c in s)
            {
                sec += dial[c - 65];
            }
            Console.WriteLine(sec);
        }
    }
}