using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string[] solution(string myString)
    {
        List<string> answer = myString.Split('x', StringSplitOptions.RemoveEmptyEntries).ToList();
        answer.Sort();
        return answer.ToArray();
    }
}