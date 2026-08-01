using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int prev = 0;
        string[] a = s.Split(" ");
        for(int i = 0; i < a.Length;++i)
        {
            if(a[i] == "Z")
            {
                answer -= prev;
            }
            else
            {
                answer += int.Parse(a[i]);
                prev = int.Parse(a[i]);
            }
        }
        return answer;
    }
}