import java.io.*;

public class Main
{
	public static void main(String[] args) throws Exception, IOException
	{
		BufferedReader I = new BufferedReader(new InputStreamReader(System.in));

		System.out.println(ESC(I.readLine()));
	}

	private static int ESC(String s)
	{
		String[] p = s.split(" ");
		int x = Integer.parseInt(p[0]);
		int y = Integer.parseInt(p[1]);
		int w = Integer.parseInt(p[2]);
		int h = Integer.parseInt(p[3]);
		int ver = 0, hor = 0;
		
		if(x < w-x)
			ver = x;
		else
			if(w-x>0)
				ver = w-x;
			else
				ver = 0;
		if(y < h-y)
			hor = y;
		else
			if(h-y>0)
				hor = h-y;
			else
				hor = 0;
		if(ver > hor)
			return hor;
		else
			return ver;
	}
}