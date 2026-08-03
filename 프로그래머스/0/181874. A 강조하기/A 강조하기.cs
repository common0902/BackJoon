using System;

public class Solution {
    public string solution(string myString) {
        string a = myString.ToLower();
        
        string answer = a.Replace('a', 'A');
        
        return answer;
    }
}