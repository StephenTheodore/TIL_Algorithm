using System;

public class Solution {
    public int solution(string myString, string pat)
    {
        int count = 0;
        for (int index = 0; index <= myString.Length - pat.Length; index++)
        {
            if (myString.Substring(index, pat.Length) == pat)
                count++;
        }
        return count;
    }
}