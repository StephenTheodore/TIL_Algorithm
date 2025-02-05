using System;
using System.Text;

public class Solution {
    public string solution(string myString) 
    {
        var sb = new StringBuilder();
        foreach(var ch in myString)
            sb.Append(ch == 'a' || ch == 'A' ? char.ToUpper(ch) : char.ToLower(ch));
        
        return $"{sb}";
    }
}