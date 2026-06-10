using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> answer = arr.ToList();
        int arrLength = answer.Count;
        while (arrLength > 0 && (arrLength & (arrLength - 1)) != 0)
        {
            answer.Add(0);
            arrLength = answer.Count;
        }
        return answer.ToArray();
    }
}