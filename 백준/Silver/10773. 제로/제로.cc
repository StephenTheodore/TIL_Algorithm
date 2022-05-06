#include <stdio.h>
#include <stack>

using namespace std;

int main()
{
	int K;
	stack<int> nums;

	scanf("%d", &K);
	for (int i = 0, val; i < K; i++)
	{
		scanf("%d", &val);
		if (val == 0)
			nums.pop();
		else
			nums.push(val);
	}

	long long sum = 0;
	while (nums.size())
	{
		sum += nums.top();
		nums.pop();
	}
	printf("%lld", sum);
}