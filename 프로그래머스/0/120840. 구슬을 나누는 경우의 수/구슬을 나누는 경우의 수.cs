using System;

public class Solution {
    public int solution(int balls, int share) => (int)Math.Round(GetFactorial(balls) / (GetFactorial(balls - share) * GetFactorial(share)));
    
    private double[] _calculated = new double[31];
    private double GetFactorial(int num) 
    {
        if (_calculated[num] == 0)
        {
            double factNum = 1.0;
            for (double rep = 2.0; rep <= num; rep++)
                factNum *= rep;
            _calculated[num] = factNum;
        }
        
        return _calculated[num];
    }
}