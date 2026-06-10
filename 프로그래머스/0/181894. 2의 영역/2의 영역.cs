using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> answer = new List<int>();
        
        int startIdx = -1;
        int endIdx = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 2)
            {
                startIdx = i;
                break;
            }
        }

        if (startIdx == -1)
        {
            answer.Add(startIdx);
        }
        else
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == 2)
                {
                    endIdx = i;
                    break;
                }
            }

            if (startIdx == endIdx)
            {
                answer.Add(2);
            }
            else
            {
                for (int i = startIdx; i <= endIdx; i++)
                {
                    answer.Add(arr[i]);
                }
            }
        }
        
        return answer.ToArray();
    }
}