import java.io.*;

public class Main
{
	public static void main(String[] args) throws Exception, IOException
	{
		BufferedReader I = new BufferedReader(new InputStreamReader(System.in));
		int x=0, y=0;
		String[] s;
		s=I.readLine().split(" ");
		x=Integer.parseInt(s[0]);
		y=Integer.parseInt(s[1]);
		s=I.readLine().split(" ");
		if(x==Integer.parseInt(s[0])) x=0;
		else x+=Integer.parseInt(s[0]);
		if(y==Integer.parseInt(s[1])) y=0;
		else y+=Integer.parseInt(s[1]);
		s=I.readLine().split(" ");
		if(x==0) x=Integer.parseInt(s[0]);
		else x-=Integer.parseInt(s[0]);
		if(y==0) y=Integer.parseInt(s[1]);
		else y-=Integer.parseInt(s[1]);
		System.out.print(x+" "+y);
	}
}