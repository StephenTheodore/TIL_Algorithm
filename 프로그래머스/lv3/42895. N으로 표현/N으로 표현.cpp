#include <string>
#include <vector>
#include <set>

using namespace std;

inline int GetN(int count, int N)
{
    int ret = N;
    for (int i = 1; i < count; i++)
    {
        (ret *= 10) += N;
    }
    return ret;
}
int solution(int N, int number)
{
    vector<set<int>> dp(9);

    for (int i = 1; i <= 8; i++)
    {
        for (int j = 0; j < i; j++)
        {
            for (int k = 0; k < i; k++)
            {
                if (j + k != i)
                    continue;
                else
                    for (int dpj : dp[j])
                    {
                        for (int dpk : dp[k])
                        {
                            dp[i].insert(dpj + dpk);
                            dp[i].insert(dpj * dpk);
                            if (dpj - dpk > 0)
                                dp[i].insert(dpj - dpk);
                            if (dpj / dpk > 0)
                                dp[i].insert(dpj / dpk);
                        }
                    }
            }
        }
        dp[i].insert(GetN(i, N));
        if (dp[i].count(number))
            return i;
    }

    return -1;
}