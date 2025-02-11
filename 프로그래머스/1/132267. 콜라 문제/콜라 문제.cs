using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int cokeCount = 0;
        int emptyBottles = 0;
        while (n-- > 0)
        {
            emptyBottles++;
            if (emptyBottles % a ==0)
            {
                cokeCount += b;
                n += b;
            }
        }
        return cokeCount;
    }
}