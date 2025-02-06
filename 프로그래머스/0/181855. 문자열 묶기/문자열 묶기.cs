using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] strArr) => strArr.GroupBy(str => str.Length).OrderByDescending(strGroup => strGroup.Count()).First().Count();
}