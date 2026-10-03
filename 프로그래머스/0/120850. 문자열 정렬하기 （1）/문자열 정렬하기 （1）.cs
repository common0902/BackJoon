using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string) {
        List<int> list = new List<int>();

        foreach (char i in my_string) 
        {
            if (int.TryParse(i.ToString(), out int num)) 
            {
                list.Add(num);
            }
        }

        list.Sort();

        return list.ToArray();
    }
}
