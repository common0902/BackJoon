using System;

public class Solution {
    public int[] solution(int[] arr, int k) {
        int[] answer = new int[arr.Length];
        for(int i = 0; i < arr.Length; ++i)
        {
            answer[i] = k % 2 == 0 ? arr[i] + k : arr[i] * k; 
        }
        return answer;
    }
}