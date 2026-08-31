using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        string a = "";
        for(int i = 0; i < myString.Length;++i)
        {
            if(myString[i] == 'A')
            {
                a += "B";
            }
            else
            {
                a += "A";
            }
        }
        return a.Contains(pat) ? 1 : 0;
    }
}