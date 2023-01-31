using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array)
    {
        var list = array.ToList();
        int[] ret = new int[2];
        
        ret[0] = list.Max();
        ret[1] = list.IndexOf(ret[0]);
        
        return ret;
    }
}