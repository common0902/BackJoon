using System;

public class Solution {
    public string solution(string my_string) {
        char[] arr = my_string.ToLower().ToCharArray();
        Array.Sort(arr);
        return new string(arr);
    }
}