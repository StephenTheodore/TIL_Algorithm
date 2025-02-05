using System;

public class Solution {
    public int solution(string binomial)
    {
        var splited = binomial.Split(' ');
        var a = Convert.ToInt32(splited[0]);
        var b = Convert.ToInt32(splited[2]);
        var op = splited[1];
        
        if (op == "+")
            return a + b;
        else if (op == "-")
            return a - b; 
        else if (op == "*")
            return a * b; 
        else
            return -1;
    }
}