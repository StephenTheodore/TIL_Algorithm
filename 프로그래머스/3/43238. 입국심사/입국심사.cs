using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public long solution(int n, int[] times)
    {
        Array.Sort(times, (a,b) => a.CompareTo(b));
        
        long left = 1, mid = 1, right = (long)times.Last() * n;
        while (left < right)
        {
            mid = (left + right) / 2;
            long people = times.Sum(time => (long)mid / time);
            
            if (people < n)
                left = ++mid;
            else
                right = mid;
        }
        
        return mid;
    }
}