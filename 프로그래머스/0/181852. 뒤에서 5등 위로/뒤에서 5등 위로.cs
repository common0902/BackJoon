using System;

public class Solution {
    public int[] solution(int[] num_list) {
        Array.Sort(num_list);
        
        int length = num_list.Length - 5;
        int[] answer = new int[length];
        
        Array.Copy(num_list, 5, answer, 0, length);
        
        return answer;
    }
}