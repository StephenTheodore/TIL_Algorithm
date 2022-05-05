#include <stdio.h>
#include <vector>
#include <string>

using namespace std;

vector<string> arr;
string startW[8] = {
"WBWBWBWB",
"BWBWBWBW",
"WBWBWBWB",
"BWBWBWBW",
"WBWBWBWB",
"BWBWBWBW",
"WBWBWBWB",
"BWBWBWBW" };
string startB[8] = {
"BWBWBWBW",
"WBWBWBWB",
"BWBWBWBW",
"WBWBWBWB",
"BWBWBWBW",
"WBWBWBWB",
"BWBWBWBW",
"WBWBWBWB" };

int paint(int x, int y)
{
	int paintStartW = 64;
	int paintStartB = 64;
	for (int r = 0; r < 8; r++)
	{
		for (int c = 0; c < 8; c++)
		{
			if (startW[r][c] == arr[x + r][y + c])
				paintStartW--;
			if (startB[r][c] == arr[x + r][y + c])
				paintStartB--;
		}
	}
	return min(paintStartW, paintStartB);
}
int main()
{
	int N, M;
	char s[51];
	int count = 64;
	scanf("%d %d", &N, &M);

	for (int i = 0; i < N; i++)
	{
		scanf("%s", &s);
		arr.push_back(s);
	}
	for (int x = 0; x <= N-8; x++)
	{
		for (int y = 0; y <= M-8; y++)
		{
			count = min(count, paint(x, y));
		}
	}
	printf("%d", count);
}
