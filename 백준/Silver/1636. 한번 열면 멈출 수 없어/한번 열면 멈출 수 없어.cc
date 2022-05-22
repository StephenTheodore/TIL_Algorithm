#include <cstdio>
#include <deque>
#include <queue>

using namespace std;

typedef pair<int, int> iPair;

deque<iPair> toxicRanges;
iPair checkStress(int pre)
{
	int count = 0;
	int min = -1, max = 201;

	for (iPair range : toxicRanges)
	{
		if (range.second < min)
			return iPair(count, min);
		else if (range.first > max)
			return iPair(count, max);
		min = range.first < min ? min : range.first;
		max = range.second > max ? max : range.second;
		count++;
	}
	if(pre < min)
		return iPair(count, min);
	else
		return iPair(count, max);
}
int main()
{
	int N;
	int total = 0;
	scanf("%d", &N);

	for (int i = 0, s, e; i < N; i++)
	{
		scanf("%d %d", &s, &e);
		toxicRanges.push_back(iPair(s, e));
	}

	if (toxicRanges.size() == 1)
		printf("0\n%d\n", toxicRanges.front().first);
	else
	{
		queue<int> stresses;
		int pre = 0;
		iPair ret;
		
		while (toxicRanges.size())
		{
			ret = checkStress(pre);
			if (stresses.size())
				total += pre >= ret.second ? pre - ret.second : ret.second - pre;
			for (int i = 0; i < ret.first; i++)
			{
				stresses.push(ret.second);
				toxicRanges.pop_front();
			}
			pre = ret.second;
		}

		printf("%d\n", total);
		while (stresses.size())
		{
			printf("%d\n", stresses.front());
			stresses.pop();
		}
	}
}