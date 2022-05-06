#include <stdio.h>
#include <vector>

using namespace std;

int main()
{
	int N;
	scanf("%d", &N);

	vector<pair<int, int>> people;
	vector<int> rank(N, 1);

	for (int i = 0, w, h; i < N; i++)
	{
		scanf("%d %d", &w, &h);
		people.push_back(pair<int, int>(w, h));
	}
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < N; j++)
		{
			if (i == j)
				continue;
			if (people[i].first < people[j].first && people[i].second < people[j].second)
				rank[i]++;
		}
		printf("%d ", rank[i]);
	}
	printf("\n");
}