static class Program
{
    static void Main(string[] args)
    {
        StreamReader sr = new(Console.OpenStandardInput());
        var fames = Array.ConvertAll(sr.ReadLine().Split(' '), Convert.ToInt64);
        Console.WriteLine(Math.Abs(fames[0] - fames[1]));
    }
}