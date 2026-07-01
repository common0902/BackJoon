using System;

public class Solution {
    public int solution(int angle) {
        int answer = 0;
        if(180 == angle) answer = 4;
        else if(90 < angle) answer = 3;
        else if(90 == angle) answer = 2;
        else answer = 1;
        return answer;
    }
}