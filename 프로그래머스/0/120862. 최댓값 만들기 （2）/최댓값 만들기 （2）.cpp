#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int solution(vector<int> numbers) {
    sort(numbers.begin(), numbers.end());
    
    int case1 = numbers[0] * numbers[1];
    int case2 = numbers[numbers.size() - 1] * numbers[numbers.size() - 2];
    
    return max(case1, case2);
}