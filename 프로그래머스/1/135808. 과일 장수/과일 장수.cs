using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int m, int[] scores) {
        var profit = 0;
        var appleQualities = scores.Where(score => score <= k).OrderByDescending(score => score).ToList();
        
        for (int index = 0; index + m <= appleQualities.Count; index += m)
        {
            var minQuality = appleQualities.Skip(index).Take(m).Min();
            profit += minQuality * m;
        }
        
        return profit;
    }
}