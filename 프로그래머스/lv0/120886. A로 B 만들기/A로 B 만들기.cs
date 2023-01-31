using System;
using System.Linq;

public class Solution {
    public int solution(string before, string after)
    {
        var distBefore = before.GroupBy(c => c).ToDictionary(g => g.Key, g => g.ToList());
        var distAfter = after.GroupBy(c => c).ToDictionary(g => g.Key, g => g.ToList());
        
        if(distBefore.Keys.Intersect(distAfter.Keys).Count() == distBefore.Keys.Count)
        {
            foreach(char key in distBefore.Keys)
            {
                if(distBefore[key].Count != distAfter[key].Count)
                    return 0;
            }
            return 1;
        }
        else
            return 0;
    }
}