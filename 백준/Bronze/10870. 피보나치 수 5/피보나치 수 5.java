import java.io.*;
public class Main
{
	public static void main(String[] args) throws Exception, IOException
	{
		BufferedReader I = new BufferedReader(new InputStreamReader(System.in));
		int N = Integer.parseInt(I.readLine());
		
		System.out.println(F(N));
	}
	private static int F(int n)
	{
		if(n==0)
			return 0;
		else if(n==1)
			return 1;
		return F(n-1)+F(n-2);
	}
}