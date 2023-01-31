using System;
using System.Text;

public class Solution {
    public string solution(int age)
    {
        StringBuilder sb = new StringBuilder();
        
        foreach(var ch in age.ToString())
            sb.Append(Convert.ToChar(97 + (int)char.GetNumericValue(ch)));
        
        return sb.ToString();
    }
}