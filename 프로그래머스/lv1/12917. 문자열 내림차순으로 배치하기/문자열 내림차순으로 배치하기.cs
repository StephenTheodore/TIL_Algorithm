using System.Linq;

public class Solution {
    public string solution(string s) => string.Join("", s.OrderBy(c => 'A'-c));
}