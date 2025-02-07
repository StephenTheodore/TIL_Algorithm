using System;
using System.Text;
using System.Linq;

public class Solution {
    public string solution(string a, string b)
    {
        var sb = new StringBuilder();
        
        bool isCarryExist = false;
        for (int indexA = a.Length - 1, indexB = b.Length - 1; indexA >= 0 || indexB >= 0; indexA--, indexB--)
        {
            int numA = indexA >= 0 ? a[indexA] - '0' : 0;
            int numB = indexB >= 0 ? b[indexB] - '0' : 0;
            
            int carry = isCarryExist ? 1 : 0;
            int sum = numA + numB + carry;
            isCarryExist = sum >= 10;
            sb.Append($"{sum%10}");
        }
        
        if (isCarryExist)
            sb.Append(1);
        
        return string.Join("", $"{sb}".Reverse());
    }
}