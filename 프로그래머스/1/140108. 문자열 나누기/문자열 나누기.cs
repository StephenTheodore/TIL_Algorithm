using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        char x = '\0';
        int sameCount = 0, notSameCount = 0;
        foreach (char c in s)
        {
            if (x == '\0')
                x = c;
            
            if (x == c)
                sameCount++;
            else
                notSameCount++;
            
            if (sameCount == notSameCount)
            {
                answer++;
                notSameCount = sameCount = 0;
                x = '\0';
            }
        }
        
        if (x != '\0')
            answer++;
        return answer;
    }
}