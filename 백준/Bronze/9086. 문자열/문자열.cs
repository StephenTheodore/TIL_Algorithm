static class Program
{
    static void Main(string[] args)
    {
        StreamReader sr = new(Console.OpenStandardInput());
        short T = Convert.ToInt16(sr.ReadLine());
        for (int i = 0; i < T; i++)
        {
            string str = sr.ReadLine();
            Console.WriteLine($"{str.FirstOrDefault()}{str.LastOrDefault()}");
        }
    }
}