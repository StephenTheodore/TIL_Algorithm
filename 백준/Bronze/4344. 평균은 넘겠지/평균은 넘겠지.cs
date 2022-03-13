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
            int n = int.Parse(sr.ReadLine());
            double survivor, students;
            double output = 0;

            for(int i=0; i<n; i++)
            {
                String[] s = sr.ReadLine().Split();

                for (int j = 1; j < s.Length; j++)
                {
                    output += double.Parse(s[j]);
                }
                students = double.Parse(s[0]);
                survivor = 0;
                output /= students;
                for (int j=1; j<s.Length; j++)
                {
                    if (double.Parse(s[j]) > output)
                        survivor++;
                }
                s = null;
                output = 0;
                Console.WriteLine(String.Format("{0:F3}%", survivor / students * 100));
            }
        }
    }
}