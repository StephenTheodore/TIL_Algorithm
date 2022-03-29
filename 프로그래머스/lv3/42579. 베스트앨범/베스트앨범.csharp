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