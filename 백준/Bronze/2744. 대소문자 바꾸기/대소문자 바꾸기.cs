using System.Text;
static class Program
{
    static void Main(string[] args)
    {
        StreamReader sr = new(Console.OpenStandardInput());
        StringBuilder sb = new();
        sr.ReadLine().ToList().ForEach(x => sb.Append(char.IsLower(x) ? char.ToUpper(x) : char.ToLower(x)));
        Console.WriteLine(sb.ToString());
    }
}