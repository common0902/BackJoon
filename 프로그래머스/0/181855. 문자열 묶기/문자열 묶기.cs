using System;
using System.Linq;

public class Solution {
    public int solution(string[] strArr) {
        int[] arr = new int[31];
        
        foreach (string s in strArr) 
        {
            arr[s.Length]++;
        }
        
        return arr.Max();
    }
}