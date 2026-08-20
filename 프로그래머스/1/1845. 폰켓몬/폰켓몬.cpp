#include <vector>
#include <map>
using namespace std;

int solution(vector<int> nums)
{
    map<int, int> m;
    int half = nums.size() / 2;
    int answer = 0;
    for(int i = 0; i < nums.size();++i)
    {
        m[nums[i]]++;
    }
    for(pair<int, int> i : m)
    {
        if(half == answer) break;
        answer++;
    }
    
    return answer;
}