/*
◆ 문제설명
조이스틱으로 알파벳 이름을 완성하세요. 맨 처음엔 A로만 이루어져 있습니다.
ex) 완성해야 하는 이름이 세 글자면 AAA, 네 글자면 AAAA

조이스틱을 각 방향으로 움직이면 아래와 같습니다.

▲ - 다음 알파벳
▼ - 이전 알파벳 (A에서 아래쪽으로 이동하면 Z로)
◀ - 커서를 왼쪽으로 이동 (첫 번째 위치에서 왼쪽으로 이동하면 마지막 문자에 커서)
▶ - 커서를 오른쪽으로 이동 (마지막 위치에서 오른쪽으로 이동하면 첫 번째 문자에 커서)

예를 들어 아래의 방법으로 "JAZ"를 만들 수 있습니다.
- 첫 번째 위치에서 조이스틱을 위로 9번 조작하여 J를 완성합니다.
- 조이스틱을 왼쪽으로 1번 조작하여 커서를 마지막 문자 위치로 이동시킵니다.
- 마지막 위치에서 조이스틱을 아래로 1번 조작하여 Z를 완성합니다.
따라서 11번 이동시켜 "JAZ"를 만들 수 있고, 이때가 최소 이동입니다.

주어진 이름에 대해 조이스틱의 최소 조작횟수를 구하세요.

◆ 매개변수
  name : 만들고자 하는 이름

◆ 제한사항
  name은 알파벳 대문자로만 이루어져 있습니다.
  name의 길이는 1 이상 20 이하입니다.
*/


using System;
using System.Linq;

public class Solution {
 private int answer = 0;
    private int idxRight = 0;
    private int idxLeft = 0;
    private bool[] comp;
    public int solution(string name)
    {
        comp = new bool[name.Length];

        //문자가 A라면 바꿔줄 필요가 없다
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i].Equals('A'))
                comp[i] = true;
        }

        //모든 문자가 일치할때까지 반복
        while (comp.Contains(false))
        {
            //문자를 바꿔줘야할 인덱스를 받고 횟수를 증가시킨다
            changeDatas(name, getNextIndex());
        }

        return answer;
    }
    private void changeDatas(string s,int idx)
    {
        //다음 인덱스를 찾기위한 정보처리
        comp[idx] = true;
        idxRight = idx;
        idxLeft = idx;

        //A를 제외한 25개의 알파벳의 중심점인 N을 기준으로 횟수를 계산한다
        answer += 13 - Math.Abs(s[idx].CompareTo('N'));
    }
    private int getNextIndex()
    {
        int toRight = 0;
        int toLeft = 0;

        //변경이 필요한 다음문자열까지 오른쪽으로 이동한 경우
        while (comp[idxRight] != false)
        {
            idxRight = (idxRight + 1) % comp.Length;
            toRight++;
        }
        //변경이 필요한 다음문자열까지 왼쪽으로 이동한 경우
        while (comp[idxLeft] != false)
        {
            if (--idxLeft < 0)
                idxLeft = comp.Length - 1;
            toLeft++;
        }

        if(toRight == toLeft)
        {
            //두 방향의 이동거리가 같다면 다음 문자까지 고려한다
            answer += toRight;
            return isLeftShortPath(idxRight, idxLeft) ? idxRight : idxLeft;
        }
        else
        {
            //더 짧은 경로를 택한다
            if (toRight < toLeft)
            {
                answer += toRight;
                return idxRight;
            }
            else
            {
                answer += toLeft;
                return idxLeft;
            }
        }
    }
    private bool isLeftShortPath(int right, int left)
    {
        int toRight = 0;
        int toLeft = 0;

        while (true)
        {
            right = (right + 1) % comp.Length;
            toRight++;
            if (comp[right] == false)
                break;
        }
        while (true)
        {
            if (--left < 0)
                left = comp.Length - 1;
            toLeft++;
            if (comp[left] == false)
                break;
        }

        return toLeft < toRight ? true : false;
    }
}