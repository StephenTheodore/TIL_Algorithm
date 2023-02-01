using System;
using System.Linq;

public class Solution {
    public int[] solution(string s)
    {
        int convertCount = 0, countZero = 0;
        while(s.Length > 1)
        {
            convertCount++;
            countZero += s.Count(c => c == '0');
            
            s = s.Replace("0", "");
            s = Convert.ToString(s.Length, 2);
        }
        return new int[] {convertCount, countZero};
    }
}