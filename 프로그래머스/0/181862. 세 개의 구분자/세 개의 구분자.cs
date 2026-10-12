using System;
using System.Linq;

public class Solution {
    public string[] solution(string myStr) {
        string[] answer = myStr.Split(new char[] { 'a', 'b', 'c' }, StringSplitOptions.RemoveEmptyEntries);
        return answer.Length > 0 ? answer : new string[] { "EMPTY" };
    }
}
