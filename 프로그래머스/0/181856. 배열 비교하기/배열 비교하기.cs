using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        
        if (arr1.Length > arr2.Length) return 1;
        if (arr1.Length < arr2.Length) return -1;
        
        int sum1 = arr1.Sum();
        int sum2 = arr2.Sum();
        
        if (sum1 > sum2) return 1;
        if (sum1 < sum2) return -1;
        
        return 0;
    }
}