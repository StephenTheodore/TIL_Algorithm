#include <stdio.h>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
	int N;
	vector<pair<int, int>> coords;

	scanf("%d", &N);
	for (int i = 0, x, y; i < N; i++)
	{
		scanf("%d %d", &x, &y);
		coords.push_back(pair<int, int>(x, y));
	}
	sort(coords.begin(), coords.end(),
		[](pair<int, int>a, pair<int, int>b) -> bool
		{
			if (a.second == b.second)
				return a.first < b.first;
			else
				return a.second < b.second;
		});
	for (pair<int, int> coord : coords)
		printf("%d %d\n", coord.first, coord.second);
}