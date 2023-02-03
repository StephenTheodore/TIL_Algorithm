using System;
using System.Linq;

class Solution 
{
    public int solution(int n) 
    {
        int count = Convert.ToString(n, 2).Count(c => c == '1');
        int num = n+1;
        
        while(Convert.ToString(num, 2).Count(c => c == '1') != count)
            num++;
        
        return num;
    }
}