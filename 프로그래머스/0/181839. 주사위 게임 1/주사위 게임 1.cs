using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int a, int b) {
        var numbers = new List<int>{a,b};
        var oddCount = numbers.Count(num => isOdd(num));
        
        if (oddCount == 2)
            return a*a+b*b;
        else if (oddCount == 1)
            return 2 * (a+b);
        else
            return Math.Abs(a-b);
    }
    
    private bool isOdd(int num) => num % 2 == 1;
}