using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        var isPrimeNum = Enumerable.Repeat(true, 10000).ToArray();
        isPrimeNum[0] = false;
        isPrimeNum[1] = false;
        for (int num = 2; num < isPrimeNum.Length; num++)
        {
            if (isPrimeNum[num] == false)
                continue;
            
            for (int nonPrimeNum = num * 2; nonPrimeNum < isPrimeNum.Length; nonPrimeNum += num)
                isPrimeNum[nonPrimeNum] = false;
        }
        
        return FindPrimeSum(nums, isPrimeNum, 0, new List<int>());
    }
        
    private int FindPrimeSum(int[] nums, bool[] primes, int startIndex, List<int> values)
    {
        if (values.Count > 3)
            return 0;
        if (values.Count == 3 && primes[values.Sum()])
            return 1;
        
        int primeSumCount = 0;
        for (int index = startIndex; index < nums.Length; index++)
        {
            values.Add(nums[index]);
            primeSumCount += FindPrimeSum(nums, primes, index + 1, values);
            values.RemoveAt(values.Count - 1);
        }
        
        return primeSumCount;
    }
}