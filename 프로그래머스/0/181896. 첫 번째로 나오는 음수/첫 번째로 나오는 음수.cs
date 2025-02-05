using System;

public class Solution {
    public int solution(int[] num_list) => Array.FindIndex(num_list, num => num < 0);
}