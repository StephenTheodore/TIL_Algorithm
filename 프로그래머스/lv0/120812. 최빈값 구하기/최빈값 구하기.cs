using System.Linq;

public class Solution {
    public int solution(int[] array)
    {
        var counts = array.GroupBy(v => v).OrderByDescending(g => g.Count());
        
        if(counts.Where(g => g.Count() == counts.First().Count()).Count() > 1)
            return -1;
        else
            return counts.First().Key;
    }
}