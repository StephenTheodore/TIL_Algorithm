#include <stdio.h>
#include <vector>
#include <set>

using namespace std;

vector<int> A;
bool findNumber(int num)
{
	int left = 0, right = A.size() - 1;
	int mid = A.size() / 2;

	while (left <= right)
	{
		if (num > A[mid])
			left = mid + 1;
		else if (num < A[mid])
			right = mid - 1;
		else
			return true;
		mid = (left + right) / 2;
	}
	return false;
}
int main()
{
	int N, M;
	int num;
	set<int> input;

	scanf("%d", &N);
	for (int i = 0; i < N; i++)
	{
		scanf("%d", &num);
		input.insert(num);
	}
	A.assign(input.begin(), input.end());
	scanf("%d", &M);
	for (int i = 0; i < M; i++)
	{
		scanf("%d", &num);
		printf("%s\n", findNumber(num) ? "1" : "0");
	}
}