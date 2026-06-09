using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] intStrs, int k, int s, int l)
    {
        List<int> answer = new List<int>();
        for (var i = 0; i < intStrs.Length; i++)
        {
            intStrs[i] = intStrs[i].Substring(s, l);
            if (Int32.Parse(intStrs[i]) > k)
            {
                answer.Add(Int32.Parse(intStrs[i]));
            }
        }
        return answer.ToArray();
    }
}