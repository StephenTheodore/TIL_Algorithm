using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n)
    {
        var filter = new bool[10001];
        for(int i = 2; i < filter.Length; i++)
        {
            if(filter[i] == false)
            {
                for(int j = i*2; j < filter.Length; j+=i)
                    filter[j] = true;
            }
        }
        
        var result = new List<int>();
        for(int index = 2; index < filter.Length && n != 1;)
        {
            if(n % index != 0 || filter[index])
                index++;
            else
            {
                result.Add(index);
                n /= index;
            }
        }
        return result.Distinct().ToArray();
    }
}