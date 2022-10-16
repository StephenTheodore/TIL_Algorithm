static class Program
{
    static void Main(string[] args)
    {
        StreamReader sr = new(Console.OpenStandardInput());
        long[] input = Array.ConvertAll(sr.ReadLine().Split(' '), Convert.ToInt64);
        Func<long, long, long> func = (long A, long B) => (A + B) * (A - B);
        Console.WriteLine(func(input[0], input[1]));
    }
}