#include <cstdio>
#include <vector>

using namespace std;
typedef vector<vector<bool>> bVector2d;

void findCabbages(bVector2d& field, bVector2d& isVisited, int x, int y)
{
	isVisited[x][y] = true;
	if (field[x + 1][y] && !isVisited[x + 1][y])
		findCabbages(field, isVisited, x + 1, y);
	if (field[x][y + 1] && !isVisited[x][y + 1])
		findCabbages(field, isVisited, x, y + 1);
	if (field[x - 1][y] && !isVisited[x - 1][y])
		findCabbages(field, isVisited, x - 1, y);
	if (field[x][y - 1] && !isVisited[x][y - 1])
		findCabbages(field, isVisited, x, y - 1);
}
int main()
{
	int T;
	scanf("%d", &T);
	for (int it = 0; it < T; it++)
	{
		int bugs = 0;
		int M, N, K;
		scanf("%d %d %d", &M, &N, &K);
		bVector2d field(M + 2, vector<bool>(N + 2, false));
		bVector2d isVisited(M + 2, vector<bool>(N + 2, false));
		for (int i = 0, x, y; i < K; i++)
		{
			scanf("%d %d", &x, &y);
			field[x + 1][y + 1] = true;
		}
		for (int i = 1; i < M + 2; i++)
		{
			for (int j = 1; j < N + 2; j++)
			{
				if (field[i][j] && !isVisited[i][j])
				{
					bugs++;
					findCabbages(field, isVisited, i, j);
				}
			}
		}
		printf("%d\n", bugs);
	}
}