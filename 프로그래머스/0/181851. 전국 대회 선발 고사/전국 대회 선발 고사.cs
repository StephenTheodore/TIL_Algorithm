using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ranks, bool[] attendances)
    {
        var participantRanks = new List<(int rank, int id)>();
        for (int index = 0; index < ranks.Length; index++)
        {
            if (attendances[index])
                participantRanks.Add((ranks[index], index));
        }
        
        var winners = participantRanks.OrderBy(rank => rank).Take(3).ToArray();
        return 10000 * winners[0].id + 100 * winners[1].id + winners[2].id;
    }
}