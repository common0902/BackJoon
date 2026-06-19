using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        bool c = Math.Abs(a) % 2 == 1;
        bool d = Math.Abs(b) % 2 == 1;
        if(c && d) answer = a * a + b * b;
        else if(c || d) answer = 2 * (a + b);
        else answer = Math.Abs(a - b);
        return answer;
    }
}