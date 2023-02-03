using System;

public class Solution {
    public int solution(int[] number)
    {
        int count = 0;
        for(int s = 0; s < number.Length; s++)
        {
            for(int d = s + 1; s < number.Length; d++)
            {
                if(d >= number.Length)
                    break;
                for(int t = d + 1; t < number.Length; t++)
                {
                    if(t >= number.Length)
                        break;
                    if(number[s]+number[d]+number[t] == 0)
                        count++;
                }
            }
        }
        
        return count;
    }
}