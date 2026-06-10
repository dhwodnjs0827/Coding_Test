using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int k)
    {
        List<int> answer = new List<int>();
        List<int> list = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (!list.Contains(arr[i]))
            {
                list.Add(arr[i]);
            }
        }

        for (int i = 0; i < k; i++)
        {
            if (i < list.Count)
            {
                answer.Add(list[i]);
            }
            else
            {
                answer.Add(-1);
            }
        }
        return answer.ToArray();
    }
}