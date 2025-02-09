using System;

public class Solution {
    public int solution(string t, string p) {
        int count = 0;
        var numP = Convert.ToDouble(p);
        for (int index = 0; index <= t.Length - p.Length; index++)
        {
            var numT = Convert.ToDouble(t.Substring(index, p.Length));
            if (numT <= numP)
                count++;
        }
        return count;
    }
}