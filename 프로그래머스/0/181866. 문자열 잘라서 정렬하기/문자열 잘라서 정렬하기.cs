using System;

public class Solution {
    public string[] solution(string myString) {
        string[] answer = myString.Split(new char[] { 'x' }, StringSplitOptions.RemoveEmptyEntries);
        
        Array.Sort(answer);
        
        return answer;
    }
}