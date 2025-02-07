using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[52];
        foreach(char ch in my_string)
        {
            if (ch < 'a')
                answer[ch - 'A']++;
            else
                answer[ch - 'a' + 26]++;
        }
        return answer;
    }
}