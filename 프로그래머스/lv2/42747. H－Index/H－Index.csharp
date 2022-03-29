using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] citations)
    {
        int H = 0;
        List<int> list = new List<int>(citations);
        list.Sort((a, b) => b.CompareTo(a));
        foreach(int n in list)
        {
            if (n == ++H)
                break;                    
            if (H > n)
            {
                H--;
                break;
            }
        }
        return H;
    }
}