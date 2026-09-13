using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        List<int> result = new List<int>();

        foreach (string str in intStrs) 
        {
            string subStr = str.Substring(s, l);
            int num = int.Parse(subStr);

            if (num > k) 
            {
                result.Add(num);
            }
        }
        
        return result.ToArray();
    }
}