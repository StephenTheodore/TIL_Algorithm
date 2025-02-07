using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        var result = new List<int>();   // Deque
        for (int index = 0; index < arr.Length; index++)
        {
            if (flag[index])
            {
                int addCount = arr[index] * 2;
                while (addCount-- > 0)
                    result.Add(arr[index]);
            }
            else
            {
                int removeCount = arr[index];
                while (removeCount-- > 0 && result.Count > 0)
                    result.RemoveAt(result.Count - 1);
            }
        }
        
        return result.ToArray();
    }
}