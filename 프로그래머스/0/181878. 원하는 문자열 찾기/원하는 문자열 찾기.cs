using System;

public class Solution {
    public int solution(string myString, string pat) => myString.ToLower().Contains(pat.ToLower()) ? 1 : 0;
}