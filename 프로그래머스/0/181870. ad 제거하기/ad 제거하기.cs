using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string[] solution(string[] strArr)
    {
        List<string> answer = strArr.ToList();
        for (int i = 0; i < strArr.Length; i++)
        {
            if (strArr[i].Contains("ad"))
            {
                answer.Remove(strArr[i]);
            }
        }
        return answer.ToArray();
    }
}