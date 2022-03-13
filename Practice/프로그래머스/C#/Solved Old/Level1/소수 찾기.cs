using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int solution(int n)
    {
        int answer=0;
        int i,j,k;
        bool[] b = new bool[n+1];
        
        for(i=2; i<n+1; i++)
        {
            for(j=i; j<n+1; j++)
            {
                if(b[i] == true)
                    break;
                if(i%j == 0)
                {
                    answer++;
                    for(k=0; k<n+1; k++)
                    {
                        if(j*k>n)
                            break;
                        else
                            b[j*k] = true;
                    }
                }
            }
        }
        return answer;
    }
}