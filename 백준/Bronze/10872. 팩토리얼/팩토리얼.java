import java.io.*;
public class Main
{
	public static void main(String[] args) throws Exception, IOException
	{
		BufferedReader I = new BufferedReader(new InputStreamReader(System.in));
		int N = Integer.parseInt(I.readLine());
		
		System.out.println(Fac(N));
	}
	private static int Fac(int n)
	{
		if(n==0)
			return 1;
		return n*Fac(n-1);
	}
}