#include <cstdio>
#include <vector>

using namespace std;

vector<int> ContinueNumber(int N , int start)
{
	int value, idx = 2;
	vector<int> numbers{ N,start };
	while (true)
	{
		value = numbers[idx - 2] - numbers[idx - 1];
		if (value < 0)
			return numbers;
		numbers.push_back(value);
		idx++;
	}
}
int main()
{
	int N;
	vector<int> maxnumbers;
	vector<int> ret;
	int maxamount = 0;
	scanf("%d", &N);

	for (int i = N/2; i <= N; i++)
	{
		ret = ContinueNumber(N, i);
		maxnumbers = ret.size() > maxnumbers.size() ? ret : maxnumbers;
	}
	printf("%d\n", maxnumbers.size());
	for (int number : maxnumbers)
	{
		printf("%d ", number);
	}
	printf("\n");
}