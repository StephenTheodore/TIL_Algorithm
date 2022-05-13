#include <cstdio>
#include <vector>

using namespace std;

vector<int> ContinueNumber(int N, int cur)
{
	int val, idx = 2;
	vector<int> nums{ N,cur };
	while (true)
	{
		val = nums[idx - 2] - nums[idx - 1];
		if (val < 0)
			return nums;
		nums.push_back(val);
		idx++;
	}
}
int main()
{
	int N;
	vector<int> maxnums;
	vector<int> ret;
	scanf("%d", &N);

	for (int i = N / 2; i <= N; i++)
	{
		ret = ContinueNumber(N, i);
		maxnums = ret.size() > maxnums.size() ? ret : maxnums;
	}

	printf("%d\n", maxnums.size());
	for (int num : maxnums)
		printf("%d ", num);
	printf("\n");
}