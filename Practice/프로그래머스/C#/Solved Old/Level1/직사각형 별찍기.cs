using System;

public class Example
{
    public static void Main()
    {
        String[] s;
        int i,j;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        for(i=0; i<b; i++)
        {
            for(j=0; j<a; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}