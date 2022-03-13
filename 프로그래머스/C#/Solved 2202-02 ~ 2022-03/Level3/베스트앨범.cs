/*
◆ 문제설명
스트리밍 사이트에서 장르 별로 가장 많이 재생된 노래를 두 개씩 모아 베스트 앨범을 출시하려 합니다.
노래는 고유 번호로 구분하며, 노래를 수록하는 기준은 다음과 같습니다.

1. 속한 노래가 많이 재생된 장르를 먼저 수록합니다.
2. 장르 내에서 많이 재생된 노래를 먼저 수록합니다.
3. 장르 내에서 재생 횟수가 같은 노래 중에서는 고유 번호가 낮은 노래를 먼저 수록합니다.

베스트 앨범에 들어갈 노래의 고유 번호의 순서를 구하세요.

◆ 매개변수
  genres : 노래의 장르를 나타내는 문자열 배열
  plays : 노래별 재생 횟수를 나타내는 정수 배열

◆ 제한사항
  genres[i]는 고유번호가 i인 노래의 장르입니다.
  plays[i]는 고유번호가 i인 노래가 재생된 횟수입니다.
  genres와 plays의 길이는 같으며, 이는 1 이상 10,000 이하입니다.
  장르 종류는 100개 미만입니다.
  장르에 속한 곡이 하나라면, 하나의 곡만 선택합니다.
  모든 장르는 재생된 횟수가 다릅니다.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    class song
    {
       public string genre;
       public int play;
       public song(string genre, int play)
       {
           this.genre = genre;
           this.play = play;
       }
    }
    public int[] solution(string[] genres, int[] plays)
    {
        int[] answer;
        Dictionary<int, song> dicList = new Dictionary<int, song>();
        Dictionary<string, int> dicGenreCount = new Dictionary<string, int>();

        for (int i = 0; i < genres.Length; i++)
        {
            dicList.Add(i, new song(genres[i], plays[i]));
            if (dicGenreCount.ContainsKey(genres[i]))
                dicGenreCount[genres[i]] += plays[i];
            else
                dicGenreCount.Add(genres[i], plays[i]);
        }
        dicList = dicList.OrderByDescending(D => D.Value.play).ToDictionary(D => D.Key, D => D.Value);
        dicGenreCount = dicGenreCount.OrderByDescending(D => D.Value).ToDictionary(D => D.Key, D => D.Value);
        int[] iCount = new int[dicGenreCount.Count];
        int[] iStore = new int[dicGenreCount.Count * 2];
        int Index = 0;
        
        for (int i = 0; i < dicGenreCount.Count; i++ )
        {
            for (int j = 0; j < dicList.Count; j++)
            {
                if (iCount[i] > 1)
                    break;
                if(dicGenreCount.ElementAt(i).Key == dicList.ElementAt(j).Value.genre)
                {
                    iStore[Index++] = dicList.ElementAt(j).Key;
                    iCount[i]++;
                }
            }
        }
        
        answer = new int[Index];
        for (int i = 0; i < answer.Length; i++ )
        {
            answer[i] = iStore[i];
        }
        return answer;
    }
}