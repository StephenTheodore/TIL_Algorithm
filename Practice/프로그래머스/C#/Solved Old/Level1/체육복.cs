using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        List<int> Lost = new List<int>(lost);
        List<int> Reserve = new List<int>(reserve);
        List<int> Dupl = new List<int>();
        int answer=0;
        
        foreach(int v1 in Lost)
        {
            foreach(int v2 in Reserve)
            {
                if(v1==v2)
                {
                    Dupl.Add(v1);
                    break;
                }
            }
        }
        foreach(int v in Dupl)
        {
            Lost.Remove(v);
            Reserve.Remove(v);
        }
        for(int i=0; i<Lost.Count; i++)
        {
            foreach(int v in Reserve)
            {
                if(v==Lost[i]-1 || v==Lost[i]+1)
                {
                    Reserve.Remove(v);   
                    answer++;
                    break;
                }
            }
        }
        
        return n - (Lost.Count - answer);
    }
}