using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int k) {
        List<int> result = new List<int>();
        
        for (int i = k; i <= n; i += k) 
        {
            result.Add(i);
        }
        
        return result.ToArray();
    }
}
