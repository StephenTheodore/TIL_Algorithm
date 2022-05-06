#include <stdio.h>
#include <vector>

using namespace std;

vector<unsigned int> cables;
long getMaxLength(unsigned int max, int N)
{
	unsigned int sht = 1, lng = max;
	unsigned int mid;
	while (sht <= lng)
	{
		mid = (sht + lng) / 2;

		int count = 0;
		for (int cable : cables)
			count += (cable / mid);

		if (count >= N)
			sht = mid + 1;
		else
			lng = mid - 1;
	}
	return lng;
}
int main()
{
	int K, N;
	unsigned int length;
	unsigned int max = 0;
	scanf("%d %d", &K, &N);

	for (int i = 0; i < K; i++)
	{
		scanf("%d", &length);
		cables.push_back(length);
		if (max < length)
			max = length;
	}
	printf("%d\n", getMaxLength(max, N));
}