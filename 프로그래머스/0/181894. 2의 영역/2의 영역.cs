using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr)
    {
        var firstIndex = Array.IndexOf(arr, 2);
        var lastIndex = Array.LastIndexOf(arr, 2);
        
        if (firstIndex == -1 && lastIndex == -1)
            return new int[] { -1 };
        if (firstIndex == lastIndex)
            return new int[] { 2 };
        else
            return arr.Skip(firstIndex).Take(lastIndex-firstIndex+1).ToArray();
    }
}