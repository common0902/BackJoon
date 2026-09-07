using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string myString) {
        List<int> list = new List<int>();
        int cnt = 0;
        foreach(char i in myString)
        {
            if(i == 'x')
            {
                list.Add(cnt);
                cnt = 0;
            }
            else
            {
                cnt++;
            }
        }
        list.Add(cnt);
        return list.ToArray();
    }
}