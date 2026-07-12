using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        foreach (int num in array) {
            string s = num.ToString();
            foreach (char c in s) {
                if (c == '7') {
                    answer++;
                }
            }
        }
        
        return answer;
    }
}