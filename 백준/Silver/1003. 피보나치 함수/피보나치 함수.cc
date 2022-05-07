#include <stdio.h>
#include <vector>

using namespace std;

int main()
{
	int T;
	int idx = 2;
	vector<pair<int, int>> DP(41);
	scanf("%d", &T);

	DP[0] = make_pair(1, 0);
	DP[1] = make_pair(0, 1);
	for (int i = 0, N; i < T; i++)
	{
		scanf("%d", &N);
		for (int j = idx; j <= N; j++)
		{
			DP[j] = make_pair(DP[j - 1].first + DP[j - 2].first, DP[j - 1].second + DP[j - 2].second);
		}
		idx = idx > N + 1 ? idx : N + 1;
		printf("%d %d\n", DP[N].first, DP[N].second);
	}
}