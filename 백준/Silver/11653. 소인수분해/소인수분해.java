import java.io.*;

public class Main
{
	public static void main(String[] args) throws Exception, IOException
	{
		BufferedReader I = new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter O = new BufferedWriter(new OutputStreamWriter(System.out));
		
		int N = Integer.parseInt(I.readLine());
		int div = 2;
		
		while(N != 1)
		{
			if(N%div == 0)
			{
				O.write(div+"\n");
				N /= div;
			}
			else
				div++;
		}
		O.flush();
	}
}