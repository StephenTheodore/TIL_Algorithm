#include <stdio.h>

using namespace std;

int fact[11]{ 1,1 };
int getFactorial(int num)
{
	if (num == 1)
		return 1;
	fact[num] = num * getFactorial(num - 1);
	return fact[num];
}
int main()
{
	int N, K;
	scanf("%d %d", &N, &K);
	getFactorial(10);

	printf("%d\n", fact[N] / (fact[K] * fact[N - K]));
}