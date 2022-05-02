#include <stdio.h>
#include <vector>

using namespace std;

int main()
{
	vector<long long> sums(1000001);
	int T, N;
	scanf("%d", &T);

	sums[1] = 1;
	for (int i = 2; i < sums.size(); i++)
	{
		for (int j = i; j < sums.size(); j += i)
		{
			sums[j] += i;
		}
		sums[i] += (sums[i - 1] + 1);
	}

	for (int i = 0; i < T; i++)
	{
		scanf("%d", &N);
		printf("%lld\n", sums[N]);
	}
}