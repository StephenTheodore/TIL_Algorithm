using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        var list = new List<string>();
        char lastChar = '\0';
        
        for(int i = 0, turn = 0; i < words.Length; i++)
        {
            if(i%n == 0)
                turn++;
                
            if(list.Contains(words[i]) == false)
                list.Add(words[i]);
            else
                return new int[] {i%n + 1, turn};
            
            if(lastChar != '\0' && lastChar != words[i].First())
                return new int[] {i%n + 1, turn};
            else
                lastChar = words[i].Last();
        }
        
        return new int[] {0, 0};
    }
}