import java.io.*;

public class Main
{
	public static void main(String[] args) throws Exception, IOException
	{
		BufferedReader I = new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter O = new BufferedWriter(new OutputStreamWriter(System.out));

		int T = Integer.parseInt(I.readLine());
		int n;
		int L, R;

		boolean[] NormalNum;

		while (T-- != 0)
		{
			n = Integer.parseInt(I.readLine());
			if (n == 0)
				return;
			L = n/2;
			R = n/2;
			NormalNum = Ret_arr(n);

			while(true)
			{
				if(NormalNum[L])
					L--;
				if(NormalNum[R])
					R++;
				if(!NormalNum[L] && !NormalNum[R])
				{
					if(L+R == n)
						break;
					else if(L+R > n )
						L--;
					else if(L+R < n)
						R++;
				}
			}
			System.out.println(L + " " + R);
		}
	}

	private static boolean[] Ret_arr(int n)
	{
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
		return NormalNum;
	}
}