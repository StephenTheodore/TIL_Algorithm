#include <stdio.h>
#include <string>

using namespace std;

int main()
{
	int N;
	int cnt = 0;
	int name = 665;
	scanf("%d", &N);

	while (cnt < N)
	{
		for (int i = ++name; i >= 666; i /= 10)
		{
			if (i % 1000 == 666)
			{
				cnt++;
				break;
			}
		}
	}
	printf("%d", name);
}