using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string s = n.ToString();
        foreach(char i in s)
            answer += i - '0';
        
        return answer;
    }
}