#include <string>
#include <vector>

using namespace std;

vector<string> solution(string my_string) {
    vector<string> answer;
    string currentStr = "";
    for(int i = 0; i < my_string.size(); ++i) {
        if(my_string[i] == ' ') 
        {
            if(currentStr != "") 
            { 
                answer.push_back(currentStr);
                currentStr = ""; 
            }
        } 
        else 
        {
            currentStr += my_string[i]; 
        }
    }
    if(currentStr != "") {
        answer.push_back(currentStr);
    }
    return answer;
}