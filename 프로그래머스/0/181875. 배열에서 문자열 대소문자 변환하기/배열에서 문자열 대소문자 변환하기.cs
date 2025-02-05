using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] strArr) 
    {
        for(int index = 0; index< strArr.Length; index++)
        {
            if(index % 2 == 0)
                strArr[index] = string.Join("", strArr[index].Select(ch => char.ToLower(ch)));
            else
                strArr[index] = string.Join("", strArr[index].Select(ch => char.ToUpper(ch)));
        }
        
        return strArr;
    }
}