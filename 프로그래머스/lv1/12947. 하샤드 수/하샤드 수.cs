using System.Linq;

public class Solution {
    public bool solution(int x) => x % x.ToString().Sum(c => char.GetNumericValue(c)) == 0;
}