using System;

public class Solution {
    public int solution(int a, int b) {
        int c = int.Parse($"{a}{b}");
        int d = int.Parse($"{b}{a}");
        
        return c > d ? c : d;
    }
}