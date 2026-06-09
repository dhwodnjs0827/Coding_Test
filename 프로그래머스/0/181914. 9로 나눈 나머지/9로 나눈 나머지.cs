using System;

public class Solution
{
    public int solution(string number)
    {
        int answer = 0;
        for (var i = 0; i < number.Length; i++)
        {
            answer += int.Parse(number[i].ToString());
        }
        return answer % 9;
    }
}