using System;

public class Solution {
    public string solution(int a, int b) => new DateTime(2016, a, b).DayOfWeek.ToString().Substring(0, 3).ToUpper();
}