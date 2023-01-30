using System;
using System.Text;

public class Solution {
    public string solution(string my_string) {
        StringBuilder sb = new StringBuilder();
        
        foreach(var ch in my_string)
            sb.Append(char.IsUpper(ch) ? char.ToLower(ch) : char.ToUpper(ch));
        
        return sb.ToString();
    }
}