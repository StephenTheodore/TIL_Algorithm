#include <stdio.h>
#include <vector>

using namespace std;

vector<int> dp(1000001);
int GetDP(int N)
{
	if (N == 1)
		return 0;
	else if (dp[N] != 0)
		return dp[N];

	dp[N] = GetDP(N - 1) + 1;
	if (N % 2 == 0)
		dp[N] = min(GetDP(N / 2) + 1, dp[N]);
	if (N % 3 == 0)
		dp[N] = min(GetDP(N / 3) + 1, dp[N]);
	return dp[N];
}
int main()
{
	int N;
	scanf("%d", &N);
	printf("%d\n", GetDP(N));
	return 0;
}