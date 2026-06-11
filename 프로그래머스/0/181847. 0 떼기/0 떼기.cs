using System;

public class Solution
{
    public string solution(string n_str)
    {
        string answer = "";
        answer = n_str.TrimStart(new char[] { '0' });
        return answer;
    }
}