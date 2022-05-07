#include <stdio.h>
#include <vector>
#define TIMEOUT 2000000000

using namespace std;

int levelingGround(vector<vector<int>> ground, int H, int B)
{
	int sec = 0;
	int work;
	for (int i = 0; i < ground.size(); i++)
	{
		for (int j = 0; j < ground[i].size(); j++)
		{
			if (ground[i][j] > H)
			{
				work = ground[i][j] - H;
				ground[i][j] -= work;
				sec += work * 2;
				B += work;
			}
			else if (ground[i][j] < H)
			{
				work = H - ground[i][j];
				ground[i][j] += work;
				sec += work;
				B -= work;
			}
		}
	}
	if (B < 0)
		return TIMEOUT;
	else
		return sec;
}
int main()
{
	int N, M, B;
	int maxheight = -1, minheight = 257;
	vector<vector<int>> ground;
	scanf("%d %d %d", &N, &M, &B);

	for (int i = 0; i < N; i++)
	{
		ground.push_back(vector<int>());
		for (int j = 0, height; j < M; j++)
		{
			scanf("%d", &height);
			ground[i].push_back(height);
			maxheight = maxheight > height ? maxheight : height;
			minheight = minheight < height ? minheight : height;
		}
	}

	int S = TIMEOUT, H = 0;
	for (int i = minheight; i <= maxheight; i++)
	{
		int ret = levelingGround(ground, i, B);
		if (S >= ret)
		{
			S = ret;
			H = i;
		}
	}

	printf("%d %d", S, H);
}