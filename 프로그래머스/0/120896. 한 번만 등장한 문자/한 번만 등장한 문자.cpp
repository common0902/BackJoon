#include <string>
#include <vector>
#include <map>

using namespace std;

string solution(string s) {
    map <char, int> m;
    string answer = "";
    
    
    for(int i = 0; i < s.size(); ++i)
    {
        m[s[i]]++;
    }
    
  
    for(auto pair : m)
    {
        if(pair.second == 1) 
        {
            answer += pair.first;
        }
    }
    return answer;
}