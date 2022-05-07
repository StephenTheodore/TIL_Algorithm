#include <stdio.h>
#include <vector>
#include <cmath>
#include <algorithm>

using namespace std;

int main()
{
	int N;
	double sum = 0;
	int most = 0; bool isSecond = false;
	int max = -4000, min = 4000;

	scanf("%d", &N);
	vector<int> values;
	vector<int> counts(8001, 0);

	for (int i = 0, val; i < N; i++)
	{
		scanf("%d", &val);
		sum += val;
		values.push_back(val);
		max = max > val ? max : val;
		min = min < val ? min : val;
		counts[val + 4000]++;
	}
	sort(values.begin(), values.end(),
		[](int a, int b) -> bool
		{
			return a < b;
		});
	for (int i = 0; i < counts.size(); i++)
	{
		if (!counts[i])
			continue;
		if (counts[most] < counts[i])
		{
			most = i;
			isSecond = false;
		}
		else if (counts[most] == counts[i] && !isSecond)
		{
			most = i;
			if (most != 0)
				isSecond = true;
		}
	}

	printf("%d\n", (int)round(sum / N));
	printf("%d\n", values[(N - 1) / 2]);
	printf("%d\n", most - 4000);
	printf("%d\n", max - min);
}