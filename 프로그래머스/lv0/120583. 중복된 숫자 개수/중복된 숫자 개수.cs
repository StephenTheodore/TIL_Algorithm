using System;
using System.Linq;

public class Solution {
    public int solution(int[] array, int n) => array.Count(num => num == n);
}