static class Program
{
    static void Main(string[] args)
    {
        StreamReader sr = new(Console.OpenStandardInput());
        List<bool> submitList = new(new bool[30]);
        for (int no = 0; no < 28; no++)
            submitList[Convert.ToInt16(sr.ReadLine()) - 1] = true;
        Console.WriteLine(submitList.FindIndex(s => !s) + 1);
        Console.WriteLine(submitList.FindLastIndex(s => !s) + 1);
    }
}