using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] diffs, int[] times, long limit)
    {
        var puzzles = new List<Puzzle>();
        var me = new Me();
        
        for (int index = 0; index < diffs.Length; index++)
            puzzles.Add(new Puzzle(diffs[index], times[index]));
        
        long prevTotalTimes = limit;
        long minSkill = diffs.Min(), maxSkill = diffs.Max();
        while (maxSkill >= minSkill)
        {
            me.SolvingSkill = (maxSkill + minSkill) / 2;
            
            (bool success, long elapsed) solveResult = me.SolvePuzzles(puzzles, limit);
            
            if (solveResult.success)
                maxSkill = me.SolvingSkill - 1;
            else
                minSkill = me.SolvingSkill + 1;
            
            prevTotalTimes = solveResult.elapsed;
        }
        
        me.SolvingSkill = minSkill;
        return (int)me.SolvingSkill;
    }
}

public class Puzzle
{
    public long Difficulty { get; private set; }
    public long SolvingTime { get; private set; }
    public long ElapsedTime { get; set;}
    
    public Puzzle(int difficulty, int solvingTime)
    {
        Difficulty = difficulty;
        SolvingTime = solvingTime;
    }
}

public class Me
{
    public long SolvingSkill { get; set; }
    
    public long SolvePuzzle(Puzzle puzzle, long prevSolvingTimes)
    {
        bool isEasyPuzzle = puzzle.Difficulty <= SolvingSkill;
        if (isEasyPuzzle)
            puzzle.ElapsedTime = puzzle.SolvingTime;
        else
        {
            long mistakes = puzzle.Difficulty - SolvingSkill;
            long elapsedForRetry = (prevSolvingTimes + puzzle.SolvingTime) * mistakes;
            puzzle.ElapsedTime = elapsedForRetry + puzzle.SolvingTime;
        }
        return puzzle.ElapsedTime;
    }
    
    public (bool solvingSuccess, long totalElapsed) SolvePuzzles(List<Puzzle> puzzles, long limit)
    {
        long totalTimes = 0;
        long prevSolvingTimes = 0;
        foreach (var puzzle in puzzles)
        {
            totalTimes += SolvePuzzle(puzzle, prevSolvingTimes);
            prevSolvingTimes = puzzle.SolvingTime;
            
            if (totalTimes > limit)
                return (false, totalTimes);
        }
        return (true, totalTimes);
    }
}