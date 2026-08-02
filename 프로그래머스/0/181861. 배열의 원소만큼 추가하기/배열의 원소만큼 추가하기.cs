using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = new List<int>();
        
        foreach(int a in arr) {
            for(int j = 0; j < a; ++j) {
                answer.Add(a);
            }
        }
        
        return answer.ToArray();
    }
}