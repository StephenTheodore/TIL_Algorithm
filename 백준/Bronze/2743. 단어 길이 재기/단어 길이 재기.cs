static class Program
{
    static void Main(string[] args)
    {
        StreamReader sr = new(Console.OpenStandardInput());
        Console.WriteLine(sr.ReadLine().Length);
    }
}