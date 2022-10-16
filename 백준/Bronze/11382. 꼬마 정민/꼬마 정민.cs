static class Program
{
    static void Main(string[] args)
    {
        StreamReader sr = new(Console.OpenStandardInput());
        Console.WriteLine(Array.ConvertAll(sr.ReadLine().Split(' '), Convert.ToInt64).ToList().Sum());
    }
}