import java.io.*;

public class Main
{
	public static void main(String[] args) throws Exception, IOException
	{
		BufferedReader I = new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter O = new BufferedWriter(new OutputStreamWriter(System.out));

		int n;

		while (true)
		{
			n = Integer.parseInt(I.readLine());
			if (n == 0)
				return;
			System.out.println(rhdgurwns(n));
		}
	}

	private static int rhdgurwns(int n)
	{
		int Cnt = 0;
		boolean[] NormalNum = new boolean[(n * 2) + 1];
		NormalNum[0] = true;
		NormalNum[1] = true;
		for (int i = 2; i <= n * 2; i++)
		{
			if (NormalNum[i] == true)
				continue;
			for (int j = i * 2; j <= n * 2; j += i)
			{
				NormalNum[j] = true;
			}
		}
		for (int i = n + 1; i <= n * 2; i++)
		{
			if (!NormalNum[i])
				Cnt++;
		}
		return Cnt;
	}
}