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
            Int32 n = Int32.Parse(sr.ReadLine());
            String[] s;
            for(int i = 0; i < n; i++)
            {
                s = sr.ReadLine().Split();
                Console.WriteLine(RoomNo(Int32.Parse(s[0]), Int32.Parse(s[1]), Int32.Parse(s[2])));
            }
        }
        static String RoomNo(Int32 H, Int32 W, Int32 N)
        {
            String Answer;
            Int32 Floor = 1, No = 1;
            while(N-H > 0)
            {
                N = N - H;
                No++;
            }
            Floor = N;
            Answer = String.Format("{0:0}{1:00}", Floor, No);
            return Answer;
        }
    }
}
