using System;
using System.Linq;

public class Solution {
    public int solution(int[] sides)
    {
        int count = 0;
        int sum = sides.Sum();
        int max = sides.Max(), min = sides.Min();
        
        for(int l = 1; l < sum; l++)
        {
            if(l+min > max)
                count++;
        }
        
        return count;
    }
}