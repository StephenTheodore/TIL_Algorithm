import java.io.*;

public class Main
{
	public static void main(String[] args) throws Exception, IOException
	{
		BufferedReader I = new BufferedReader(new InputStreamReader(System.in));
		
		int M = Integer.parseInt(I.readLine());
		int N = Integer.parseInt(I.readLine());
		boolean[] NormalNum = new boolean[N+1];
		int count;
		int sum = 0, min = N;

        NormalNum[0] = true;
        NormalNum[1] = true;
        for (int i = 2; i <= N; i++)
        {
            if (NormalNum[i] == true)
                continue;
            count = 0;
            for (int j = 1; j < i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                    continue;
                }
                if (count > 1)
                {
                    break;
                }
            }
            if (count == 1)
            {
                for(int k = 2;;k++)
                {
                    if (i * k > N)
                        break;
                    NormalNum[(i * k)] = true;
                }
            }
        }
        for(int i = M; i<=N; i++)
        {
        	if(!NormalNum[i])
        	{
        		sum += i;
        		if(min > i)
        			min = i;
        	}
        }
        if(sum == 0)
        	System.out.println(-1);
        else
        {
        	System.out.println(sum);
        	System.out.println(min);
        }
	}
}