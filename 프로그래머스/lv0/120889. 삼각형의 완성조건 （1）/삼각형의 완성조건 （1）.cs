using System;
using System.Linq;

public class Solution {
    public int solution(int[] sides) {
        int maxSide = sides.Max();
        
        return maxSide < sides.Sum()-maxSide ? 1 : 2;
    }
}