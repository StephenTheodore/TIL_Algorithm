using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) => num_list.Length >= 11 ? num_list.Sum() : num_list.Aggregate((output, next) => output *= next);
}