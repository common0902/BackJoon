using System;

public class Solution {
    public int[] solution(int[] array) {
         int[] answer = new int[2];
        int a = 0;
        int b = 0;
        
        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] > a) 
            {
                a = array[i];
                b = i;
            }
        }
        
        answer[0] = a;
        answer[1] = b;
        
        return answer;
    }
}