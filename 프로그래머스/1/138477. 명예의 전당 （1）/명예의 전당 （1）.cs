using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] scores) {
        var hallOfHonor = new List<int> { scores[0] };
        var scoreHistory = new List<int> { scores[0] };
        
        for (int index = 1; index < scores.Length; index++)
        {
            var score = scores[index];
            var maxScore = hallOfHonor.Max();
            
            if (hallOfHonor.Count > k)
                hallOfHonor.Add(Math.Max(score, maxScore));
            else
                hallOfHonor.Add(score);
            
            while (hallOfHonor.Count > k)
                hallOfHonor.Remove(hallOfHonor.Min());
            
            scoreHistory.Add(hallOfHonor.Min());
        }
        
        return scoreHistory.ToArray();
    }
}