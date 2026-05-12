using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 2 * a * b;
        int c = int.Parse(a.ToString() + b.ToString());
        if (c > answer) answer = c;
        return answer;
    }
}