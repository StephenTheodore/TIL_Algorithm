using System.Collections.Generic;

public class Solution {
    public int[] solution(long n)
    {
        var list = new List<int>();
        
        foreach(var ch in n.ToString())
        {
            list.Insert(0, (int)char.GetNumericValue(ch));
        }
        
        return list.ToArray();
    }
}