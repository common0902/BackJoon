using System;

public class Solution {
    public int solution(int chicken) {
        int answer = 0;
        int a = chicken;
        
        while (a >= 10) 
        {
            int b = a / 10;
            answer += b;
            a = b + (a % 10);
        }
        
        return answer;
    }
}