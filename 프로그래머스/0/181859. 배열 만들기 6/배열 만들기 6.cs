using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        var stk = new List<int>();
        
        for (int index = 0; index < arr.Length; index++)
        {
            if (stk.Count == 0)
                stk.Add(arr[index]);
            else if (stk[stk.Count - 1] == arr[index])
                stk.RemoveAt(stk.Count - 1);
            else
                stk.Add(arr[index]);
        }
        
        return stk.Count > 0 ? stk.ToArray() : new int[]{-1};
    }
}