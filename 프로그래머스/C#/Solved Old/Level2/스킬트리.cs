/*
◆ 문제설명
선행 스킬이란 어떤 스킬을 배우기 전에 먼저 배워야 하는 스킬을 뜻합니다.

예를 들어 선행 스킬 순서가 스파크 → 라이트닝 볼트 → 썬더일때
썬더를 배우려면 먼저 라이트닝 볼트를 배워야 하고, 라이트닝 볼트를 배우려면 먼저 스파크를 배워야 합니다.

위 순서에 없는 다른 스킬(힐링 등)은 순서에 상관없이 배울 수 있습니다.
따라서 스파크 → 힐링 → 라이트닝 볼트 → 썬더와 같은 스킬트리는 가능하지만
썬더 → 스파크나 라이트닝 볼트 → 스파크 → 힐링 → 썬더와 같은 스킬트리는 불가능합니다.

가능한 스킬트리의 개수를 구해야합니다.

◆ 매개변수
  skill : 선행 스킬 순서
  skill_trees : 유저들이 만든 스킬트리를 담은 배열

◆ 제한조건
  스킬은 알파벳 대문자로 표기하며, 모든 문자열은 알파벳 대문자로만 이루어져 있습니다.
  스킬 순서와 스킬트리는 문자열로 표기합니다.
  예를 들어, C → B → D 라면 "CBD"로 표기합니다
1.skill
  선행 스킬 순서 skill의 길이는 1 이상 26 이하이며, 스킬은 중복해 주어지지 않습니다.
2.skill_trees
  skill_trees는 길이 1 이상 20 이하인 배열입니다.
  skill_trees의 원소는 스킬을 나타내는 문자열입니다.
  skill_trees의 원소는 길이가 2 이상 26 이하인 문자열이며, 스킬이 중복해 주어지지 않습니다.
*/

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