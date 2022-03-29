using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        List<int> answer = new List<int>();
        bool[] comp = new bool[progresses.Length+1];
        int cnt=0;
        int i,j;
        int pub = 0;
        int index = 0;
        
        
        while(pub < progresses.Length)
        {
            for(i=0; i<progresses.Length; i++)
            {
                progresses[i] += speeds[i];
                if(progresses[i] >= 100)
                {
                    comp[i] = true;
                }

            }
            while(comp[pub] == true)
            {
                pub++;
                cnt++;
            }
            if(cnt!=0)
            {
                answer.Add(cnt);
                cnt = 0;
            }
        }
        return answer.ToArray();
    }
}