using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string s)
    {
        int[] answer = new int[s.Length];
        Dictionary<char, int> dict = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i]))
            {
                answer[i] = -1;
                dict.Add(s[i], i);
            }
            else
            {
                answer[i] = i - dict[s[i]];
                dict[s[i]] = i;
            }
        }
        return answer;
    }
}