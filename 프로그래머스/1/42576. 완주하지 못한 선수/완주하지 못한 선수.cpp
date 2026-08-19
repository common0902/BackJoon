#include <string>
#include <vector>
#include <map>

using namespace std;

string solution(vector<string> participant, vector<string> completion) {
    map<string, int> m;
    string answer = "";
    for(int i = 0; i < participant.size(); ++i) 
    {
        m[participant[i]]++;
    }
    for(int i = 0; i < completion.size(); ++i) 
    {
        m[completion[i]]--;
    }
    for(pair<string,int> i : m )
    {
        if(i.second == 1)
        {
            answer = i.first;
        }
    }
    
    return answer;
}