import java.io.*;

public class Main
{
	public static void main(String[] args) throws Exception, IOException
	{
		BufferedReader I = new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter O = new BufferedWriter(new OutputStreamWriter(System.out));

		int T = Integer.parseInt(I.readLine());
		String[] loc;

		while (T-- != 0)
		{
			loc = I.readLine().split(" ");
			System.out.println(Tele(Integer.parseInt(loc[0]), Integer.parseInt(loc[1])));
		}
	}

	private static int Tele(int x, int y)
	{
		int Dis = y - x;
		int Mov = 1;
		int Cnt = 0;
		boolean sw = false;

		while (Dis > 0)
		{
			Dis -= Mov;
			Cnt++;
			if (sw)
				Mov++;
			sw = !sw;
		}
		return Cnt;
	}
}