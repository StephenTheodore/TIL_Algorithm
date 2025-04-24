#include <string>
#include <vector>

using namespace std;

vector<vector<int>> solution(int n) {
    vector<vector<int>> answer;
    
    for (int dim1 = 0; dim1 < n; dim1++)
        answer.push_back(vector<int>(n));
    
    char direction = 'R';   // R, B, L, T
    int row = 0;
    int col = 0;
    for (int num = 0; num < n * n; num++)
    {
        answer[row][col] = num + 1;
        
        switch (direction)
        {
            case 'R':
                if (col + 1 < n && answer[row][col + 1] == 0)
                    col++;
                else
                {
                    direction = 'B';
                    row++;
                }
                break;
            case 'B':
                if (row + 1 < n && answer[row + 1][col] == 0)
                    row++;
                else
                {
                    direction = 'L';
                    col--;
                }
                break;
            case 'L':
                if (col - 1 >= 0 && answer[row][col - 1] == 0)
                    col--;
                else
                {
                    direction = 'T';
                    row--;
                }
                break;
            case 'T':
                if (row - 1 >= 0 && answer[row - 1][col] == 0)
                    row--;
                else
                {
                    direction = 'R';
                    col++;
                }
                break;
        }
    }
    
    return answer;
}