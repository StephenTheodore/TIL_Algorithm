using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) => array.OrderBy(n =>n).ElementAt(array.Length/2);
}