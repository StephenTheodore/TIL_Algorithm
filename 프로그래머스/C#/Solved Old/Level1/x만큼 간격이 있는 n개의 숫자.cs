using System.Collections.Generic;

public class Solution {
    public long[] solution(int x, int n) {
        List<long> answer = new List<long>();
        
        for(int i = 1; i <= n; i++)
        {
            
            answer.Add((long)(x*i));
        }
        
        return answer.ToArray();
    }
}