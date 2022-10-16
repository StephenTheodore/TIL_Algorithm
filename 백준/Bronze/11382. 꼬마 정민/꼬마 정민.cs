static class Program
{
    static void Main(string[] args)
    {
        StreamReader sr = new(Console.OpenStandardInput());
        long sum = 0;
        foreach (string str in sr.ReadLine().Split(' '))
            sum += Convert.ToInt64(str);
        Console.WriteLine(sum);
    }
}