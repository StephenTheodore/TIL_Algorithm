#include <stdio.h>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
	int N;
	int x, y;
	vector<pair<int, int>> points;

	scanf("%d", &N);
	while (N--)
	{
		scanf("%d %d", &x, &y);
		points.push_back(pair<int, int>(x, y));
	}
	sort(points.begin(), points.end(),
		[](pair<int, int> a, pair<int, int> b)->bool
		{
			if (a.first != b.first)
				return a.first < b.first;
			else
				return a.second < b.second;
		});
	for (pair<int, int> point : points)
	{
		printf("%d %d\n", point.first, point.second);
	}
}