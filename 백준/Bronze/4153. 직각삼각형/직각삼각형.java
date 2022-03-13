import java.io.*;

public class Main
{
	public static void main(String[] args) throws Exception, IOException
	{
		BufferedReader I = new BufferedReader(new InputStreamReader(System.in));
		String[] S;
		while(true)
		{
			S = I.readLine().split(" ");
			if(Integer.parseInt(S[0])==0 && Integer.parseInt(S[1])==0 && Integer.parseInt(S[2])==0)
				return;
			System.out.println(J(Integer.parseInt(S[0]),Integer.parseInt(S[1]),Integer.parseInt(S[2]))?"right":"wrong");
		}
	}
	private static boolean J(int a, int b, int c)
	{
		a*=a;
		b*=b;
		c*=c;
		if(a+b==c)
			return true;
		else if(a+c==b)
			return true;
		else if(b+c==a)
			return true;
		else
			return false;
	}
}