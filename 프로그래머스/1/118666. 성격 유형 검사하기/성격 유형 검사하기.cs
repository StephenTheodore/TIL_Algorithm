using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        
        var personalityScores = new Dictionary<char, int>
        {
            {'R',0}, {'C',0}, {'J',0}, {'A',0},
            {'T',0}, {'F',0}, {'M',0}, {'N',0},
        };
        
        for (int index = 0; index < choices.Length; index++)
        {
            var score = choices[index] - 4;
            if (score < 0)
            {
                var affectOnDisagree = survey[index][0];
                personalityScores[affectOnDisagree] += Math.Abs(score);
            }
            else if (score > 0)
            {
                var affectOnAgree = survey[index][1];
                personalityScores[affectOnAgree] += score;
            }
        }
        
        var indicRT = personalityScores['R'] >= personalityScores['T'] ? 'R' : 'T';
        var indicCF = personalityScores['C'] >= personalityScores['F'] ? 'C' : 'F';
        var indicJM = personalityScores['J'] >= personalityScores['M'] ? 'J' : 'M';
        var indicAN = personalityScores['A'] >= personalityScores['N'] ? 'A' : 'N';
        return $"{indicRT}{indicCF}{indicJM}{indicAN}";
    }
}