using System;
using System.Text;

public class Example
{
    public static void Main()
    {
        Console.Clear();
        
        StringBuilder sb = new StringBuilder();
        string[] s = Console.ReadLine().Split(' ');

        int n = Int32.Parse(s[0]);

        for(int i = 1; i <= n; i++)
        {
            for(int j = 0; j < i; j++)
                sb.Append("*");
            sb.AppendLine();
        }
        
        Console.WriteLine(sb.ToString());
    }
}