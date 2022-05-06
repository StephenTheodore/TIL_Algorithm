#include <stdio.h>
#include <vector>
#include <queue>

using namespace std;

int main()
{
	int T, N, M;

	scanf("%d", &T);
	for (int i = 0; i < T; i++)
	{
		queue<pair<int, int>> qIdx;
		vector<int> vPri(10);
		int pri = 1;
		scanf("%d %d", &N, &M);

		for (int idx = 0, val; idx < N; idx++)
		{
			scanf("%d", &val);
			vPri[val]++;
			qIdx.push(pair<int, int>(idx, val));
			if (pri < val)
				pri = val;
		}

		int cnt = 0;
		while (true)
		{
			if (!vPri[pri])
				pri--;
			else
			{
				if (qIdx.front().second == pri)
				{
					if (qIdx.front().first == M)
						break;
					qIdx.pop();
					vPri[pri]--;
					cnt++;
				}
				else
				{
					qIdx.push(qIdx.front());
					qIdx.pop();
				}
			}
		}
		printf("%d\n", cnt + 1);
	}
}