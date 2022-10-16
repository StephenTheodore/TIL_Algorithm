static class Program
{
    static void Main(string[] args)
    {
        StreamReader sr = new(Console.OpenStandardInput());
        sr.ReadLine();
        var numbers = sr.ReadLine().Split(' ').ToList();
        var target = sr.ReadLine();
        Console.WriteLine(numbers.Count(n => n == target));
    }
}