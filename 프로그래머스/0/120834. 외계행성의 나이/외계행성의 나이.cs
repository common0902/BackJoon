using System;

public class Solution {
    public string solution(int age) {
        string a = age.ToString();
        string answer = "";
        
        for(int i = 0; i < a.Length; ++i)
        {
            answer += (char)(a[i] - '0' + 97);
        }
        return answer;
    }
}