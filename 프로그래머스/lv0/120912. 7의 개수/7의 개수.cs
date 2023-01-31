using System;
using System.Linq;

public class Solution {
    public int solution(int[] array)
    {
        int count = 0;
        for(int index = 0; index < array.Length; index++)
        {
            foreach(var ch in array[index].ToString())
            {
                if(ch == '7')
                    count++;
            }
        }
        return count;
    }
}