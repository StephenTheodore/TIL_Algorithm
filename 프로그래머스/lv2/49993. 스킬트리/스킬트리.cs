using System;

public class Solution
{
    public int solution(string skill, string[] skill_trees)
    {
        int answer = 0;
        bool[] IsReq;
        int[] skill_index;
        int Req, Next, CurTree = 0;

        while (CurTree < skill_trees.Length)
        {
            IsReq = new bool[skill_trees[CurTree].Length];
            skill_index = new int[skill.Length];
            Req = 0;
            Next = 0;
            for (int i = 0; i < skill.Length; i++)
                skill_index[i] = -1;
            for (int i = 0; i < skill.Length; i++)
            {
                if (skill_trees[CurTree].Contains(skill[i].ToString()))
                {
                    skill_index[i] = skill_trees[CurTree].IndexOf(skill[i]);
                    IsReq[skill_index[i]] = true;
                    Req++;
                }
            }
            for (int i = 0; i < skill_trees[CurTree].Length; i++)
            {
                if (IsReq[i] == true && skill_index[Next] == i)
                    Next++;
                else if (IsReq[i] == true && skill_index[Next] != i)
                    break;
            }
            if (Req == Next)
                answer++;
            CurTree++;
        }
        return answer;
    }
}