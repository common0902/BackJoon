using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int m, int c) {
        StringBuilder answer = new StringBuilder();
        
        for (int i = c - 1; i < my_string.Length; i += m) 
        {
            answer.Append(my_string[i]);
        }
        
        return answer.ToString();
    }
}
