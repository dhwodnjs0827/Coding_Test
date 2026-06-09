using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string my_string, string is_suffix)
    {
        int n = 0;
        List<string> answer = new List<string>();
        for (int i = 0; i < my_string.Length; i++)
        {
            answer.Add(my_string.Substring(i, my_string.Length - i));
        }

        foreach (var str in answer)
        {
            if (str.Equals(is_suffix))
            {
                n = 1;
                break;
            }
        }
        return n;
    }
}