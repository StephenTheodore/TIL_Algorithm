using System.Text;

static class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new();
        StreamReader sr = new(Console.OpenStandardInput());
        List<short[]> array = new();
        short N = Convert.ToInt16(sr.ReadLine().Split(' ')[0]);
        for (short row = 0; row < N; row++)
            array.Add(Array.ConvertAll(sr.ReadLine().Split(' '), Convert.ToInt16));
        for (short row = 0; row < N; row++)
        {
            short[] numbers = Array.ConvertAll(sr.ReadLine().Split(' '), Convert.ToInt16);
            for (int col = 0; col < array[row].Length; col++)
                sb.Append($"{array[row][col] + numbers[col]} ");
            sb.AppendLine();
        }
        Console.Write(sb.ToString());
    }
}