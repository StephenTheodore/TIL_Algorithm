using System;
using System.Linq;

public class Solution {
    public int solution(string[] babbling) {
        var babbles = new string[] { "aya", "ye", "woo", "ma" };
        
        for (int index = 0; index < babbling.Length; index++)
        {
            foreach (string babble in babbles)
                babbling[index] = babbling[index].Replace(babble, "@");
        }
        
        return babbling.Count(babble => babble.Replace("@", "").Length == 0);
    }
}