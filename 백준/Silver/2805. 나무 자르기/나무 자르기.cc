#include <stdio.h>
#include <vector>
#define LL long long

using namespace std;

int main()
{
	LL N, M;
	LL max = 0;
	vector<LL> trees;

	scanf("%lld %lld", &N, &M);
	for (LL i = 0, val; i < N; i++)
	{
		scanf("%lld", &val);
		trees.push_back(val);
		max = max > val ? max : val;
	}

	LL low = 0, high = max, H;
	while (low <= high)
	{
		H = (low + high) / 2;
		LL sum = 0;
		for (LL height : trees)
		{
			if (height - H > 0)
				sum += (height - H);
		}

		if (sum >= M)
			low = H + 1;
		else
			high = H - 1;
	}
	printf("%lld\n", high);
}