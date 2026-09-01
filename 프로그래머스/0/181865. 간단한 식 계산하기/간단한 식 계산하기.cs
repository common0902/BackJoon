using System;

public class Solution {
    public int solution(string binomial) {
        int answer = 0;
        string[] arr = binomial.Split(" ");
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[2]);
        switch(arr[1])
        {
            case "+":
                answer = a + b;
                break;
            case "-":
                answer = a - b;
                break;
            case "*":
                answer = a * b;
                break;
        }
        return answer;
    }
}