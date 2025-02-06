using System;
using System.Linq;

public class Solution {
    public int solution(string[] order) => order.Sum(coffeeName => {
        if (coffeeName.Contains("latte"))
            return 5000;
        else
            return 4500;
    });
}