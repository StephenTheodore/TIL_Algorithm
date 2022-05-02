#include <stdio.h>
#include <vector>

using namespace std;

int main()
{
	int N, M;
	vector<int> arr(100001);
	scanf("%d", &N);

	for (int i = 0; i < N; i++)
	{
		scanf("%d", &M);
		arr[M]++;
	}
	for (int i = 0; i < arr.size(); i++)
	{
		while (arr[i]--)
		{
			printf("%d\n", i);
		}
	}
}