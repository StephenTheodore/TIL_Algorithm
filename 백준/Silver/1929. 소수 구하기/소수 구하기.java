import java.io.*;

public class Main
{
	public static void main(String[] args) throws Exception, IOException
	{
		BufferedReader I = new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter O = new BufferedWriter(new OutputStreamWriter(System.out));
		
		String[] s = I.readLine().split(" ");
		int M = Integer.parseInt(s[0]);
		int N = Integer.parseInt(s[1]);
		
		boolean[] NormalNum = new boolean[N+1];

        NormalNum[0] = true;
        NormalNum[1] = true;
        for (int i = 2; i*i <= N; i++)
        {
            if (NormalNum[i] == true)
                continue;
            for (int j = i*i; j <= N; j += i)
            {
                NormalNum[j] = true;
            }
        }
        for(int i = M; i <= N; i++)
        {
        	if(!NormalNum[i])
        		O.write(i+"\n");
        }
        O.flush();
	}
}