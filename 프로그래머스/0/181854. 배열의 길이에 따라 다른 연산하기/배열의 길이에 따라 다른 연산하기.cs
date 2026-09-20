using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int[] answer = new int[arr.Length];
        bool even = (arr.Length % 2 == 0);

        for (int i = 0; i < arr.Length; ++i) 
        {
            if ((even && i % 2 != 0) || (!even && i % 2 == 0)) 
            {
                answer[i] = arr[i] + n;
            } 
            else 
            {
                answer[i] = arr[i];
            }
        }
        return answer;
    }
}