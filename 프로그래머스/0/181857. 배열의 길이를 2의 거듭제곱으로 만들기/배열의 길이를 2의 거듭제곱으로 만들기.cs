using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        var powNums = new List<int> { 1 };
        
        int initializer = 1;
        while (initializer <= 1024)
        {
            powNums.Add(initializer);
            initializer *= 2;
        }
        
        int zerosCount = powNums.Find(pow => pow >= arr.Length) - arr.Length;
        return arr.Concat(new int[zerosCount]).ToArray();
    }
}