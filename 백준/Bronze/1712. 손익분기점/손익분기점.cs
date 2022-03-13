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
            String[] s;

            s = sr.ReadLine().Split();
            
            Console.WriteLine(CalcBreakEvenPoint(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2])));
        }
        static int CalcBreakEvenPoint(int Cost_Fixed, int Cost_Variable, int Price)
        {

            if (Cost_Variable > Price || Cost_Variable - Price == 0)
                return -1;

            return (Cost_Fixed / (Price - Cost_Variable)) + 1;
        }
    }
}