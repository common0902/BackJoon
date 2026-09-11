using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        char[] charArray = my_string.ToCharArray();
        
        Array.Reverse(charArray, s, e - s + 1);
        
        return new string(charArray);
    }
}