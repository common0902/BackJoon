using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        return num_list.Length > 10 ? num_list.Sum() : num_list.Aggregate((a, b) => a * b);
    }
}