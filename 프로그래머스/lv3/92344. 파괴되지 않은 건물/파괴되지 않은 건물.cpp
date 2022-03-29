#include <vector>

using namespace std;

int solution(vector<vector<int>> board, vector<vector<int>> skills)
{
    int map[1002][1002];
    int answer = 0;

    for (vector<int> skill : skills)
    {
        if (skill[0] == 1)
            skill[5] *= -1;
        map[skill[1]][skill[2]] += skill[5];
        map[skill[1]][skill[4] + 1] -= skill[5];
        map[skill[3] + 1][skill[2]] -= skill[5];
        map[skill[3] + 1][skill[4] + 1] += skill[5];
    }
    for (int i = 1; i < board.size(); i++)
    {
        for (int j = 0; j < board[0].size(); j++)
        {
            map[i][j] += map[i - 1][j];
        }
    }
    for (int i = 0; i < board.size(); i++)
    {
        for (int j = 1; j < board[0].size(); j++)
        {
            map[i][j] += map[i][j - 1];
        }
    }
    for (int i = 0; i < board.size(); i++)
    {
        for (int j = 0; j < board[0].size(); j++)
        {
            if (map[i][j] + board[i][j] > 0)
                answer++;
        }
    }

    return answer;
}