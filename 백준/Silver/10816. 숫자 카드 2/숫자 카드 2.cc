#include <stdio.h>
#include <vector>

using namespace std;

int main()
{
	int N, M, value;
	const int Size = 10000001;
	vector<int> AP(Size), AN(Size);

	scanf("%d", &N);
	for (int i = 0; i < N; i++)
	{
		scanf("%d", &value);
		if (value >= 0)
			AP[value]++;
		else
			AN[value * -1]++;
	}
	scanf("%d", &M);
	for (int i = 0; i < M; i++)
	{
		scanf("%d", &value);
		printf("%d ", value >= 0 ? AP[value] : AN[value * -1]);
	}
	printf("\n");
}