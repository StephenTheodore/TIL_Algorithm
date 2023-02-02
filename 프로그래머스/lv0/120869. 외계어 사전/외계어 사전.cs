using System;
using System.Linq;

public class Solution {
    public int solution(string[] spell, string[] dic)
    {
        var list = spell.ToList();
        return dic.ToList().Any(w => list.All(c => w.Contains(c))) ? 1 : 2;
    }
}