using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) => num_list.OrderBy(num => num).Skip(5).ToArray();
}