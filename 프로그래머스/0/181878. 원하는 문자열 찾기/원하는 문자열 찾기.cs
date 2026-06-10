using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        int answer = 0;
        string myStringLower = myString.ToLower();
        string patLower = pat.ToLower();
        answer = myStringLower.Contains(patLower) ? 1 : 0;
        return answer;
    }
}