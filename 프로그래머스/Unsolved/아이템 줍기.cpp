#include <iostream>
#include <vector>

using namespace std;

int imos[51][51];
int moveChar(int cx, int cy, int ix, int iy)
{
    int lx = cx, rx = cx;
    int ly = cy, ry = cy;
    int lc = 0, rc = 0;
    return min(lc, rc);
}
int solution(vector<vector<int>> rectangles, int characterX, int characterY, int itemX, int itemY)
{
    fill(&imos[0][0], &imos[50][51], 0);
    for (vector<int> rect : rectangles)
    {
        //imos로 할 경우 덮어씌우는 과정에서 모양이 날아간다..
        imos[rect[0]][rect[1]] += 1;
        imos[rect[0]][rect[3] + 1] -= 1;
        imos[rect[2]+1][rect[1]] -= 1;
        imos[rect[2]+1][rect[3] + 1] += 1;
    }
    for (int i = 1; i < 51; i++)
    {
        for (int j = 0; j < 51; j++)
        {
            imos[i][j] += imos[i - 1][j];
        }
    }
    for (int i = 0; i < 51; i++)
    {
        for (int j = 1; j < 51; j++)
        {
            imos[i][j] += imos[i][j - 1];
        }
    }
    for (int i = 0; i < 51; i++)
    {
        for (int j = 0; j < 51; j++)
        {
            if (i == characterX && j == characterY)
                cout << "C";
            else if (i == itemX && j == itemY)
                cout << "T";
            else if (imos[i][j] != 0)
                cout << imos[i][j];
            else
                cout << "-";
        }
        cout << endl;
    }

    return 0;
}
int main()
{
    vector<vector<int>> v1;
    v1.push_back({ 1,1,7,4 });
    v1.push_back({ 3,2,5,5 });
    v1.push_back({ 4,3,6,9 });
    v1.push_back({ 2,6,8,8 });
    cout << solution(v1, 1, 3, 7, 8) << endl;

    vector<vector<int>> v2;
    v2.push_back({ 1,1,8,4 });
    v2.push_back({ 2,2,4,9 });
    v2.push_back({ 3,6,9,8 });
    v2.push_back({ 6,3,7,7 });
    cout << solution(v2, 9, 7, 6, 1) << endl;

    vector<vector<int>> v3;
    v3.push_back({ 1,1,5,7 });
    cout << solution(v3, 1, 1, 6, 3) << endl;

    vector<vector<int>> v4;
    v4.push_back({ 2,1,7,5 });
    v4.push_back({ 6,4,10,10 });
    cout << solution(v4, 3, 1, 7, 10) << endl;
}
