using System;
using System.Linq;

public class Solution {
    public int solution(int order) => order.ToString().Count(c => c == '3' || c == '6' || c == '9');
}