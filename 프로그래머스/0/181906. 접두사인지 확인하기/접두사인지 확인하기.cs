using System;

public class Solution {
    public int solution(string my_string, string is_prefix) => my_string.IndexOf(is_prefix) == 0 ? 1 : 0;
}