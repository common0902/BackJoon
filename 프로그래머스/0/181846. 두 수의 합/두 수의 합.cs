using System;
using System.Numerics;

public class Solution {
    public string solution(string a, string b) {
        BigInteger A = BigInteger.Parse(a);
        BigInteger B = BigInteger.Parse(b);
        return (A + B).ToString();
    }
}