using System;
using System.Text;

public class Solution {
    public int solution(string A, string B) {
        var sb = new StringBuilder(A);
        int count = 0;
        
        while ($"{sb}" != B)
        {
            sb.Insert(0, sb[sb.Length - 1]);
            sb.Remove(sb.Length - 1, 1);
            if (count >= A.Length && $"{sb}" == A)
                return -1;
                    
            count++;
        }
        return count;
    }
}