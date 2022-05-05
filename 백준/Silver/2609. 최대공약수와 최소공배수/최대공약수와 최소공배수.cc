#include <stdio.h>
#include <algorithm>

using namespace std;

int main()
{
	int N, M;
	int G;
	scanf("%d %d", &N, &M);

	for (int i = min(N, M); i > 0; i--)
	{
		if (N % i == 0 && M % i == 0)
		{
			G = i;
			printf("%d\n", G);
			break;
		}
	}
	printf("%d\n", M * N / G);
}