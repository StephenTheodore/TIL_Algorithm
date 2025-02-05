using System;
using System.Linq;

public class Solution {
    public int solution(string myString, string pat) {
        var convertedCharArray = myString.Select(ch => {
            if(ch == 'A')
                return 'B';
            else
                return 'A';
        });
        var convertedString = string.Join("", convertedCharArray);
        
        return convertedString.Contains(pat) ? 1 : 0;
    }
}