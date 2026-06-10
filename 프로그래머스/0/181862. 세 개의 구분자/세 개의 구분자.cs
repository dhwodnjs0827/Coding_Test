using System;

public class Solution
{
    public string[] solution(string myStr)
    {
        string[] answer = new string[] { };
        string[] words = myStr.Split(new char[] { 'a', 'b', 'c' }, StringSplitOptions.RemoveEmptyEntries);
        answer = words.Length > 0 ? words : new string[] { "EMPTY" };
        return answer;
    }
}