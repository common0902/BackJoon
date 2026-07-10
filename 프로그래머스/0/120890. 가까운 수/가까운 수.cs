using System;

public class Solution {
    public int solution(int[] array, int n) {
        Array.Sort(array);
        int min = 101;
        int answer = 0;
        for(int i = 0; i < array.Length;++i)
        {
            if(Math.Abs(array[i] - n) < min)
            {
                min = Math.Abs(array[i] - n);
                answer = array[i];
            }
        }
        return answer;
    }
}