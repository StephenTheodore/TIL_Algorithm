using System;
using System.Text;

public class Solution {
    public string solution(string s) {
        StringBuilder answer = new StringBuilder();
        String[] Strs = s.Split();
        int max = int.Parse(Strs[0]);
        int min = int.Parse(Strs[0]);

        for(int i = 1; i < Strs.Length; i++)
        {
            if(int.Parse(Strs[i]) > max)
                max = int.Parse(Strs[i]);
            if(min > int.Parse(Strs[i]))
                min = int.Parse(Strs[i]);
        }
        answer.Append(min.ToString() + " ");
        answer.Append(max.ToString());

        return answer.ToString();
    }
}