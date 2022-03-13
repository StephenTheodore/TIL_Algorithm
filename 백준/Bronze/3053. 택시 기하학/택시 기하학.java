import java.io.*;
public class Main
{
	public static void main(String[] args) throws Exception, IOException
	{
		BufferedReader I = new BufferedReader(new InputStreamReader(System.in));
		double Eu, Taxi;
		double R = Integer.parseInt(I.readLine());
		Eu = Math.PI*R*R;
		Taxi = 2*R*R;
		System.out.printf("%.6f%n%.6f",Eu,Taxi);
	}
}