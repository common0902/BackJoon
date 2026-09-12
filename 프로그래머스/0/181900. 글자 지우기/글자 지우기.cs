using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int[] indices) {
        char[] strArr = my_string.ToCharArray();
        
        foreach (int index in indices) 
        {
            strArr[index] = ' ';
        }
        
        StringBuilder sb = new StringBuilder();
        foreach (char c in strArr) 
        {
            if (c != ' ') 
            {
                sb.Append(c);
            }
        }
        
        return sb.ToString();
    }
}