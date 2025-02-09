using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        var indices = new Dictionary<char, int>();
        var result = new List<int>();
        for (int index = 0; index < s.Length; index++)
        {
            var currentChar = s[index];
            if (indices.ContainsKey(currentChar) == false)
                result.Add(-1);
            else
                result.Add(index - indices[currentChar]);
            indices[currentChar] = index;
        }
        
        return result.ToArray();
    }
}