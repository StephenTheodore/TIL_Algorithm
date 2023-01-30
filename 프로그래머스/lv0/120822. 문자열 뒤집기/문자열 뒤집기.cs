using System;
using System.Text;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        StringBuilder sb = new StringBuilder();
        sb.Append(my_string.Reverse().ToArray());
        return sb.ToString();
    }
}