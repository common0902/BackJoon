using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        string a = order.ToString();
        for(int i = 0; i < a.Length; ++i)
        {
            if(a[i] is '3' or '6' or '9') answer++;
        }
        return answer;
    }
}