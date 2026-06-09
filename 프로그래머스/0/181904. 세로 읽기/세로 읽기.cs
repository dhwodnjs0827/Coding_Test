using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string my_string, int m, int c)
    {
        List<char[]> results = new List<char[]>();
        int col = my_string.Length / m;
        for (int i = 0; i < col; i++)
        {
            var tmp = my_string.Substring(i * m, m);
            results.Add(tmp.ToCharArray());
        }
        string answer = "";
        for (int i = 0; i < col; i++)
        {
            answer += results[i][c-1];
        }
        return answer;
    }
}