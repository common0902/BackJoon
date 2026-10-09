using System;

public class Solution {
    public int solution(int n) {
        double sqrt = Math.Sqrt(n);
        return (sqrt % 1 == 0) ? 1 : 2;  
    }
}