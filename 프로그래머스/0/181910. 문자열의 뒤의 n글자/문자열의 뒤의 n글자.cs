using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        int diff = my_string.Length - n;
        for(int i = 0; i < my_string.Length; ++i)
        {
            if( i < diff) continue;
            answer += my_string[i];
        }
        return answer;
    }
}