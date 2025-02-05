using System;
using System.Text;

public class Solution {
    public string solution(string my_string, string alp)
    {
        StringBuilder sb = new StringBuilder();
        foreach(var ch in my_string)
            sb.Append(alp.Contains(ch) ? char.ToUpper(ch) : ch);
        
        return $"{sb}";
    }
}