using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    List<int> list = new List<int>();
    public int solution(int[] elements) 
    {
        for(int i = 1; i <= elements.Length; i++)
            StoreSum(elements, i);
        
        return list.Distinct().Count();
    }
    public void StoreSum(int[] array, int count)
    {
        for(int i = 0; i < array.Length; i++)
        {
            int sum = 0;
            for(int j = 0; j < count; j++)
                sum += array[(i+j) % array.Length];
            list.Add(sum);
        }
    }
}