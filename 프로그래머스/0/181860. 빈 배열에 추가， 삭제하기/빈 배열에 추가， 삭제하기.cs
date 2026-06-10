using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, bool[] flag)
    {
        List<int> answer = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (flag[i])
            {
                for (int j = 0; j < arr[i] * 2; j++)
                {
                    answer.Add(arr[i]);
                }
            }
            else
            {
                answer.RemoveRange(answer.Count - arr[i], arr[i]);
            }
        }

        return answer.ToArray();
    }
}