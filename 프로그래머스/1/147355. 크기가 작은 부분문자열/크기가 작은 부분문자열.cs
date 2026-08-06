using System;

public class Solution
{
    public int solution(string t, string p)
    {
        int answer = 0;
        int trimLenght = p.Length;
        for (int i = 0; i <= t.Length - trimLenght; i++)
        {
            string trim = t.Substring(i, trimLenght);
            long num = long.Parse(trim);
            if (num <= long.Parse(p))
            {
                answer++;
            }
        }
        return answer;
    }
}