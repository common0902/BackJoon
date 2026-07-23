#include <string>
#include <vector>

using namespace std;

vector<string> solution(string my_str, int n) {
    vector<string> answer;
    string a = "";
    for(int i = 0; i < my_str.size(); ++i)
    {
        a += my_str[i];
        if((i + 1) % n == 0)
        {
            answer.push_back(a);
            a = "";
        }
        
    }
    if(a != "")
        answer.push_back(a);
    return answer;
}