using System;

public class Solution
{
    public int solution(string num_str)
    {
        int answer = 0;
        foreach (var c in num_str)
        {
            answer += Convert.ToInt32(c) - '0';
        }
        return answer;
    }
}