using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[] order)
    {
        int answer = 0;
        Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>()
        {
            {4500, new List<string>(){"iceamericano", "americanoice", "hotamericano", "americanohot", "americano", "anything"}},
            {5000, new List<string>(){"icecafelatte", "cafelatteice", "hotcafelatte", "cafelattehot", "cafelatte"}}
        };
        for (int i = 0; i < order.Length; i++)
        {
            if (dict[4500].Contains(order[i]))
            {
                answer += 4500;
            }
            else
            {
                answer += 5000;
            }
        }
        return answer;
    }
}