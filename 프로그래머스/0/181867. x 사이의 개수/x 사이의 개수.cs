using System;
using System.Linq;

public class Solution {
    public int[] solution(string myString) => myString.Split('x').Select(str => str.Length).ToArray();
}