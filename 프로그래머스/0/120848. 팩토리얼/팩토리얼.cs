using System;

public class Solution {
    public int solution(int n) {
        int a = 1;
        for(int i = 1; i <= 10; ++i)
        {
            a *= i;
            if(a > n) return i - 1;
        }
        return 10;

    }
}