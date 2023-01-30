using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int hp) {
        List<int> ants = new List<int>();
        
        ants.Add(hp/5);
        hp -= 5 * ants[0];
        ants.Add(hp/3);
        hp -= 3 * ants[1];
        ants.Add(hp/1);
        hp -= 3 * ants[2];
        
        return ants.Sum();
    }
}