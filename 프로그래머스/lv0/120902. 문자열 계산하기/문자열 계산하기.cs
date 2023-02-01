using System;

public class Solution {
    public int solution(string my_string)
    {
        var split = my_string.Split(' ');
        int sum = 0;
        
        sum += Convert.ToInt32(split[0]);
        for(int m = 1, r = 2; r < split.Length; m+=2, r+=2)
        {
            int oper = split[m] == "+" ? 1 : -1;
            int num = Convert.ToInt32(split[r]);
            
            sum += num*oper;
        }
        
        return sum;
    }
}