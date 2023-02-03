using System;
using System.Linq;

public class Solution {
    public int solution(int n) {
        string s = "";
        int decim = 0;
        
        while(n>0)
        {
            s += (n%3).ToString();
            n /= 3;
        }
        for(int i = 0; i < s.Length; i++)
        {
            int digit = (int)Math.Pow(3, s.Length - i-1);
            
            if(digit != 0)
                decim += (int)char.GetNumericValue(s[i]) * digit;
            else
                decim += (int)char.GetNumericValue(s[i]);
        }
        
        return decim;
    }
}