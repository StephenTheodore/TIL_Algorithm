using System;
using System.Linq;

public class Solution {
    public int solution(int[] array, int height) => array.Count(h => h > height);
}