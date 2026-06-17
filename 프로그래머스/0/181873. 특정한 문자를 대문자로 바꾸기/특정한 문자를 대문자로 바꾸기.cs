using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string answer = "";
    
        for(int i = 0; i < my_string.Length; ++i)
        {
            if(my_string[i].ToString() == alp) answer += my_string[i].ToString().ToUpper();
            else answer += my_string[i];
        }
        return answer;
    }
}