#include <string>
#include <vector>

using namespace std;

vector<string> solution(vector<string> strArr) {
    vector<string> answer;
    for(int i = 0; i < strArr.size(); ++i) 
    {
        bool hasAd = false;
        
        for(int j = 0; j + 1 < strArr[i].size(); j++) 
        {
            if(strArr[i][j] == 'a' && strArr[i][j+1] == 'd') 
            {
                hasAd = true; 
                break;
            }
        }
        
        if(!hasAd) 
        {
            answer.push_back(strArr[i]);
        }
    }
    return answer;
}